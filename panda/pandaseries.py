"""What is a Series?
A Pandas Series is like a column in a table.

It is a one-dimensional array holding data of any type."""

import pandas as pd

a = [1, 7, 2,"data",4.0,True]

myvar = pd.Series(a)

#print(myvar)

"""Labels
If nothing else is specified, the values are labeled with their index number. First value has index 0, second value has index 1 etc.

This label can be used to access a specified value."""
#print(myvar[4])


"""Create Labels
With the index argument, you can name your own labels.

Example
Create your own labels:"""

import pandas as pd

a = [1, 7, 2]

myvar1 = pd.Series(a, index = ["x", "y", "z"])

print(myvar1)