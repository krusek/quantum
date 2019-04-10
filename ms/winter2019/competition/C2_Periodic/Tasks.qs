// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    operation Solve_old (x : Qubit[], y: Qubit) : Unit {
        body(...) {
            let N = Length(x);
            using (ps = Qubit[N-1]) {
                CheckPeriods(x, ps, N);
                OrOracle(ps, y);
                Adjoint CheckPeriods(x, ps, N);
            }
        }
        adjoint auto;
    }

    function Sum (controls: Qubit[][][]): Int {
        mutable sum = 0;
        for (control in controls) {
            set sum = sum + Length(control);
        }
        return sum;
    }

    operation Equal(left: Qubit[], right: Qubit[], y: Qubit) : Unit {
        body(...) {
            let N = Length(left);
            if (N == 1) {
                let all = left + right;
                Controlled X(all, y);
                ApplyToEachCA(X, all);
                Controlled X(all, y);
                ApplyToEachCA(X, all);
            } else {
                let half = N / 2; // half = 1
                using (q = Qubit[2]) {
                    Equal(left[0..half-1], right[0..half-1], q[0]);
                    Equal(left[half..N-1], right[half..N-1], q[1]);
                    //Equal(q[0..0],q[1..1], y);
                    Controlled X(q, y);
                    Equal(left[0..half-1], right[0..half-1], q[0]);
                    Equal(left[half..N-1], right[half..N-1], q[1]);
                }
            }
        }
        adjoint self;
    }

    operation Solve(x: Qubit[], y: Qubit): Unit {
        body(...) {
            let N = Length(x);
            using (periods = Qubit[N/2]) {
                for (p in 0..N/2-1) {
                    //Message($"comparing 0..{p} and {N-p-1}..{N-1}");
                    Equal(x[0..p], x[N-p-1..N-1], periods[p]);
                }
                OrOracle(periods, y);
                for (p in 0..N/2-1) {
                    Equal(x[0..p], x[N-p-1..N-1], periods[p]);
                }
            }
        }
        adjoint self;
    }

    operation Solve_new(x: Qubit[], y: Qubit): Unit {
        body(...) {
            let N = Length(x);
            using (periods = Qubit[N-1]) {
                let AllControls = Map(GetControls(x, _), IntArrayFromRange(1..N-1));
                let controlsLength = Sum(AllControls);
                // Message($"big controls length: {controlsLength}");
                using (bigcontrols = Qubit[controlsLength]) {
                    mutable start = 0;
                    for (p in 1..N-1) {
                        // Message($"start: {start}, p: {p}");
                        let controls = AllControls[p-1];
                        let qc = bigcontrols[start..start+Length(controls)-1];
                        for (ix in 0..Length(controls)-1) {
                            let cnt = controls[ix];
                            Controlled X(cnt, qc[ix]);
                            ApplyToEachCA(X, cnt);
                            Controlled X(cnt, qc[ix]);
                            ApplyToEachCA(X, cnt);
                        }
                        Controlled X(qc, periods[p-1]);
                        set start = start + Length(controls);
                    }
                    OrOracle(periods, y);
                    set start = 0;
                    for (p in 1..N-1) {
                        let controls = AllControls[p-1];
                        let qc = bigcontrols[start..start+Length(controls)-1];
                        Controlled X(qc, periods[p-1]);
                        for (ix in 0..Length(controls)-1) {
                            let cnt = controls[ix];
                            Controlled X(cnt, qc[ix]);
                            ApplyToEachCA(X, cnt);
                            Controlled X(cnt, qc[ix]);
                            ApplyToEachCA(X, cnt);
                        }
                        Controlled X(qc, periods[p-1]);
                        set start = start + Length(controls);
                    }
                }
            }
        }
        adjoint self;
    }

    operation CheckPeriods(x: Qubit[], ps: Qubit[], N: Int) : Unit {
        body(...) {
            for (p in 1..N-1) {
                if (not AlreadyChecked(p, N, true)) {
                    // Message($"checking {p}");
                    // CheckEquality(x[0..ix-1], x[N-ix..N-1], y);
                    IsPeriodic(x, p, ps[p-1]);
                }
            }
        }
        adjoint auto;
    }

    function AlreadyChecked(ix: Int, N: Int, print: Bool) : Bool {
        mutable overlaps = 0;
        for (iy in ix+1..N-1) {
            if (iy % ix == 0 && not AlreadyChecked(iy, N, false)) {
                set overlaps = overlaps + 1;
            }
        }
        let skip = (overlaps % 2 == 1);
        return skip;
    }

    operation OrOracle(x: Qubit[], y: Qubit) : Unit {
        body(...) {
            ApplyToEachCA(X, x);
            Controlled X(x, y);
            ApplyToEachCA(X, x);
            X(y);
        }
        controlled auto;
        adjoint auto;
        controlled adjoint auto;
    }

    operation IsPeriodic(x: Qubit[], p: Int, y: Qubit) : Unit {
        body(...) {
            let length = GetControlsLength(x, p);
            using (q = Qubit[length]) {
                ApplyPeriod(x, q, p);
                Controlled X(q, y);
                ApplyPeriod(x, q, p);
            }
        }
        adjoint auto;
    }

    function GetControls(x: Qubit[], p: Int) : Qubit[][] {
        // Message($"get controls for {p} and {Length(x)}");
        if (UseBigger(x, p)) {
            // Message($"bigger for {p} and {Length(x)}");
            return GetBiggerControls(x, p);
        } else {
            return GetSmallerControls(x, p);
        }
    }

    function UseBigger(x: Qubit[], p: Int) : Bool {
        if (p >= (Length(x) - 1)/2) {
            return true;
        } else {   
            return false;
        }
    }

    function GetSmallerControls(x: Qubit[], p: Int) : Qubit[][] {
        mutable controls = new Qubit[][p];
        for (ix in 0..p-1) {
            mutable cntrl = new Qubit[0];
            for (iy in ix..Length(x)-1) {
                if (ix == (iy % p)) {
                    set cntrl = cntrl + [x[iy]];
                }
            }
            if (Length(cntrl) > 1) {
                set controls[ix] = cntrl;
            }
        }
        return controls;
    }

    function GetControlsLength(x: Qubit[], p: Int) : Int {
        let N = Length(x);
        if (UseBigger(x, p)) {
            return N-p;
        } else { 
            return p;
        }
    }

    function GetBiggerControls(x: Qubit[], p: Int) : Qubit[][] {
        let N = Length(x);
        let len = GetControlsLength(x, p);
        mutable controls = new Qubit[][len];
        // Message($"{len} controls");
        for (ix in 0..len-1) {
            // Message($"controls: {ix} and {N-len+ix}");
            set controls[ix] = [x[ix], x[N-len+ix]];
        }
        return controls;
    }

    operation ApplyPeriod(x: Qubit[], q: Qubit[], cp: Int) : Unit {
        body(...) {
            let p = Length(q);
            let controls = GetControls(x, cp);
            for (ix in 0..Length(controls)-1) {
                let cnt = controls[ix];
                // if (Length(cnt) < 2) {
                //     X(q[ix]);
                // } else {
                    Controlled X(cnt, q[ix]);
                    ApplyToEachCA(X, cnt);
                    Controlled X(cnt, q[ix]);
                    ApplyToEachCA(X, cnt);
                // }
            }
        }
        adjoint auto;
    }

    // operation ApplyToEach(op: ((Qubit) => Unit : Adjoint, Controlled), x: Qubit[]) : Unit {
    //     body(...) {
    //         for (ix in 0..Length(x) - 1) {
    //             op(x[ix]);
    //         }
    //     }
    //     adjoint auto;
    //     controlled auto;
    //     adjoint controlled auto;
    // }
}
