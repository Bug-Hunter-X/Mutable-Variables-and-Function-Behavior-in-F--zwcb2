# F# Mutable Variable Bug

This example demonstrates a potential source of confusion when using mutable variables in F# functions. The `add` function modifies both `x` and `y`, leading to an unexpected result.

## Problem
The output of the code is not what one might initially expect. The function `add` modifies the value of `x`, but the result reflects the value of `y` before the modification. The value of `x` is also unexpectedly changed.

## Solution
The provided solution clarifies the behavior by avoiding unintended side effects, offering a safer and clearer approach when working with mutable variables in F#.
