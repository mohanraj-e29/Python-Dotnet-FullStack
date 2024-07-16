"""What is a DataFrame?
A Pandas DataFrame is a 2 dimensional data structure, like a 2 dimensional array, or a table with rows and columns.

"""

import pandas as pd

#just like json code key:value pair seperated by comma...
data = {
  "calories": [420, 380, 390,500,367],
  "duration": [50, 40, 45,90,87]
}

#load data into a DataFrame object:
df = pd.DataFrame(data)

print(df,"\n") 

#Return row 0 and 1:
print(df.loc[[0, 1]],"\n")

"""Named Indexes
With the index argument, you can name your own indexes.
"""


import pandas as pd

data = {
  "calories": [420, 380, 390],
  "duration": [50, 40, 45]
}

df = pd.DataFrame(data, index = ["day1", "day2", "day3"])

print(df)   

"""Locate Named Indexes
Use the named index in the loc attribute to return the specified row(s).

Example
Return "day2":

#refer to the named index:"""
print()
print("--------------------","\n")
print(df.loc["day3"])



"""Load Files Into a DataFrame
If your data sets are stored in a file, Pandas can load them into a DataFrame.

Example
Load a comma separated file (CSV file) into a DataFrame:"""

import pandas as pd

df1 = pd.read_csv('data.csv')

print(df1.to_string()) 