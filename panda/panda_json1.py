import pandas as pd
import json

try:
    # Read the JSON data from the file
    """with open('datas.json', 'r') as json_file:: This line opens the file named 'datas.json' in read mode ('r') using a context manager (with statement). The file is opened and
    assigned to the variable json_file. Using a context manager ensures that the file is properly closed after its suite (indented block of code) is executed."""
    with open('datas.json', 'r') as json_file:
        """file_content = json_file.read(): This line reads the entire content of the file json_file and assigns it to the variable file_content."""
        
        file_content = json_file.read()

    # Parse the JSON data
    """data = json.loads(file_content): This line parses the JSON string file_content and converts it into a Python dictionary data using the json.loads() function. This process is
    known as deserialization."""
    data = json.loads(file_content)

    # Convert the JSON data to a DataFrame
    """df = pd.DataFrame(data['books']): This line creates a Pandas DataFrame df from the dictionary data['books']. Each key-value pair in data['books'] becomes a column in the
    DataFrame, where keys are column names and values are column values."""
    df = pd.DataFrame(data['books'])

    # Print the DataFrame
    print(df)

except FileNotFoundError:
    print("Error: File 'datas.json' not found.")

except json.JSONDecodeError as e:
    print(f"Error decoding JSON: {e}")
