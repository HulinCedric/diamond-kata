# Diamond Kata

This description is copied from [Seb Rose blog](http://claysnow.co.uk/recycling-tests-in-tdd/)

## Description

Given a letter, print a diamond starting with 'A' with the supplied letter at the widest point.

For example: print-diamond 'C' prints

``` text
  A
 B B
C   C
 B B
  A
```

## Approaches

One goal of this repository is to illustrate and compile, with my understanding, different test-driven approaches on a
well known exercise.

Each approaches have it's respective test suite directory.

Also, each approaches have its respective branch containing solution.

### Example-Driven Development

#### Iterative approach

Seb Rose used an iterative approach, where he 'recycle' test cases.

TDD approach encourages us to incrementally build a safety net of tests that anchor the solution.

Recycling approach acknowledges that the test we have just written does not identify a universal truth, we can iterate
on our understanding.

[Recycling tests in TDD](http://claysnow.co.uk/recycling-tests-in-tdd)

[Diamond recycling (and painting yourself into a corner)](http://claysnow.co.uk/diamond-recycling-and-painting-yourself-into-a-corner)