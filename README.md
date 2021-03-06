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

## Repository goals

### Coding

One goal of this repository is to experiment with one or many approaches in the same exercise guided by tests.

Because the exercise is the same, it is simpler to switch from one approach to others without the cognitive load of a
new problem.

This let focusing on what is really important here, the approach.

### Discovering

The other goal of this repository is to illustrate and compile, with my understanding, different "test-driven
development" approaches in a well-known exercise.

Because the exercise is the same, it is simple to figure out what each approach provides.

Of course, there are best suited approaches depending on the problem, but all are relevant depending on the constraints.
There are no better approaches than another, it's context depending.

Each approach has its respective test suite.

Also, each approach has its respective branch containing a solution.

## Iterative approach

Seb Rose used an iterative approach, where he 'recycle' test cases.

TDD approach encourages us to incrementally build a safety net of tests that anchor the solution.

Recycling approach acknowledges that the test we have just written does not identify a universal truth, we can iterate
on our understanding.

[Recycling tests in TDD](http://claysnow.co.uk/recycling-tests-in-tdd)

[Diamond recycling (and painting yourself into a corner)](http://claysnow.co.uk/diamond-recycling-and-painting-yourself-into-a-corner)

## Incremental approach

Incremental approach is more common and encourages thinking before coding.

### Example-Driven Development

#### Inside-out

Inside-out approach is also known as the Detroit School of TDD, Classicist or black-box testing.

The goal is to split the problem into smaller ones, verified by a set of tests that are universally true, so did not
need to be recycled.

With such an approach, we can incrementally emerge out a solution. Author thinking draw the outline of the solution
path.

To illustrate one of the possible paths, the [Sandro Mancuso approach](https://github.com/sandromancuso/diamond_kata)
inspired the Incremental suite tests of this repository.

There are a lot of other possible paths (maybe illustrate here later):

- [George Dinwiddie approach](https://blog.gdinwiddie.com/2014/11/30/another-approach-to-the-diamond-kata)
- [Ron Jeffries approach](https://ronjeffries.com/articles/tdd-diamond)
- And many more... search "diamond kata" on the web ;)

#### Outside-in

Outside-in approach drive development by starting with an acceptance test who expect from diamond, the final requirement.

The acceptance test guide developers to prevent losing focus of the final goal.

It is a little harder to find the path to the solution, because we are starting with the whole problem. By using, preparatory refactoring and TDD techniques, the solution can incrementally be driven by the acceptance test.

There are three techniques for quickly getting to green:

- Fake It: Return a constant and gradually replace constants with variables until you have real code.
- Obvious Implementation: Type in the real implementation.
- Triangulation: Only generalize code when we have two examples or more.

In outside-in TDD, the acceptance test represents the outer loop. It is possible to create new unit test files for the inner loop, so to test classes behaviors that emerge during the implementation and refactoring of the outer loop requirement.

### Property-Driven Development

In contrast to example-driven approach, property-driven idea is to validate an expected property of a system. It's a paint of the system behavior contour.

Examples aren't necessary, a range of input will assert the property validity.

With such an approach, we can incrementally constraints properties of the system under test, in order to reach the
solution.

To illustrate one of the possible paths, the [Mark Seemann approach](https://github.com/ploeh/DiamondFsCheck)
inspired the property-driven suite tests of this repository.

Mark Seemann use [Devil's Advocate](https://blog.ploeh.dk/2019/10/07/devils-advocate) to force him to write properties
that completely describe the problem.

[Diamond kata with FsCheck](https://blog.ploeh.dk/2015/01/10/diamond-kata-with-fscheck)

There are a lot of other possible paths (maybe illustrate here later):

- [Nat Pryce approach](http://natpryce.com/articles/000807.html) and his [Thoughts on Incremental Development](http://natpryce.com/articles/000809.html)
- And many more... search "diamond kata property-based testing" on the web ;)
