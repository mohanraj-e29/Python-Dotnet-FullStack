"""What is Pandas?
Pandas is a Python library used for working with data sets.

It has functions for analyzing, cleaning, exploring, and manipulating data.

The name "Pandas" has a reference to both "Panel Data", and "Python Data Analysis" and was created by Wes McKinney in 2008.

Why Use Pandas?
Pandas allows us to analyze big data and make conclusions based on statistical theories.

Pandas can clean messy data sets, and make them readable and relevant.

Relevant data is very important in data science.


Pandas is usually imported under the pd alias.

alias: In Python alias are an alternate name for referring to the same thing.

Create an alias with the as keyword while importing:"""
### single line comments

import pandas as pd

"""mydataset = {
  'cars': ["BMW", "Volvo", "Ford","Ferrari","Bugati","Tesla"],
  'passings': [3, 7, 2, 8, 9, 2 ]
}

myvar = pd.DataFrame(mydataset)

print(myvar)"""
print(pd.__version__)