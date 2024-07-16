n=int(input("Enter the value:"))
for n in range(n):
   if(n % 3==0):
      print("Accord")
      if(n %5==0):
        print("Matrix")
        if(n % 3==0) and (n %5==0):
           print("Accord Info Matrix")
  