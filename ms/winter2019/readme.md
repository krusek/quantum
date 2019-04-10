This folder contains my solutions (or attempts at them) for [Microsoft's Q# coding warmup - winter 2019](https://codeforces.com/contests/1115) and [Microsoft's Q# coding contest - winter 2019](https://codeforces.com/contest/1116/). The warmup was rather easy and I got all the problems solved in a few hours. The contest was significantly harder than last years. This time I solved all but three before the contest ended and then solved another one of those the day the contest ended.

To run any of the test go to the appropriate directory, for example `competition/A1_Three_State` and run `dotnet test`.

# competition

This has my solutions to the 2019 winter contest. I did not successfully solve B1, B2 or D6. Although B1 I did later solve the day the competition ended. On the train ride home from work I realized how I could solve it.

Here is a [link](https://codeforces.com/contest/1116/) to the competition.

# warmup

This has my solutions to the 2019 winter warmup. It turned out to be pretty easy. I was able to solve all the problems in a few hours.


Here is a [link](https://codeforces.com/contest/1115/) to the competition.

# template

This is just a template that I was able to copy / paste as I started working on a new problem. It simply contains a `Tasks.qs` file and a `Tests.qs` file along with some helper files to make sure `dotnet test` runs correctly. `Tests.qs` calls `Tasks.qs`. I would need to update `Tests.qs` such that it correctly tests the problem and I would need to update the `Solve` method of `Tasks.qs` such that it solves the problem. Later I would upload `Tasks.qs` to codeforces to verify my solution.

For some of the problems the main goal was just to make sure that whatever I uploaded to codeforces would properly compile. That was in the case where writing a test turned out to be very difficult.

# unitary_template

For the competition and warmup there were a lot of problems involving creating unitary matrices of certain forms. Therefore it was useful to have a template specifically for getting prepared to solve one of those problems.