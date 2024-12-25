// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.
namespace Solution {
    open Microsoft.Quantum.MachineLearning;

    operation Solve () : (ControlledRotation[], (Double[], Double)) {
        // your code here
        // error rate of 6%
        return (
            [

            ControlledRotation((0, new Int[0]), PauliZ, 4),
            ControlledRotation((0, new Int[0]), PauliX, 5),
            ControlledRotation((1, new Int[0]), PauliZ, 6),
            ControlledRotation((1, new Int[0]), PauliX, 7),
            ControlledRotation((0, [1]), PauliX, 0),
            ControlledRotation((1, [0]), PauliX, 1),
            ControlledRotation((1, new Int[0]), PauliX, 2),
            ControlledRotation((1, new Int[0]), PauliZ, 3)
            ],
            (
                [0.5864553485999999,3.3712858377,0.8703179580093751,2.934490520109375,1.1556584211093752,3.067628013109375,2.274436532109375,5.630420900109375],
0.12117012517521647
            )
        );
        // return (
        //     [
        //         ControlledRotation((0, new Int[0]), PauliX, 4),
        //         ControlledRotation((0, new Int[0]), PauliZ, 5),
        //         ControlledRotation((1, new Int[0]), PauliX, 6),
        //         ControlledRotation((1, new Int[0]), PauliZ, 7),
        //         ControlledRotation((0, [1]), PauliX, 0),
        //         ControlledRotation((1, [0]), PauliX, 1),
        //         ControlledRotation((1, new Int[0]), PauliZ, 2),
        //         ControlledRotation((1, new Int[0]), PauliX, 3)
        //     ], (
        //     [
        //         0.06065757,
        //         2.9751678,
        //         2.0606841984375,
        //         0.6384631984374999,
        //         1.0576329984374997,
        //         1.2755677984374998,
        //         4.0703872984375,
        //         5.4069454984375
        //     ],
        //     0.11610185579682537)
        // );
    }
}
