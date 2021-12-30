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

#### Incremental approach

Incremental approach is more common and encourages thinking before coding.

The goal is to split the problem into smaller ones, verified by a set of tests that are universally true, so did not
need to be recycled.

With such an approach, we can incrementally find a solution. Author thinking draw the outline of the solution path.

To illustrate one of the possible paths, the [Sandro Mancuso approach](https://github.com/sandromancuso/diamond_kata)
inspired the Incremental suite tests of this repository.

There are a lot of other possible paths (maybe illustrate here later):

- [George Dinwiddie approach](https://blog.gdinwiddie.com/2014/11/30/another-approach-to-the-diamond-kata)
- [Ron Jeffries approach](https://ronjeffries.com/articles/tdd-diamond)
- And many more... search "diamond kata" on the web ;)
