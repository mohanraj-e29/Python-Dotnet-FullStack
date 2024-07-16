e=int(input("Enter the English Mark="))
t=int(input("Enter the Tamil Mark="))
m=int(input("Enter the Maths Mark="))
sci=int(input("Enter the Science Mark="))
soc=int(input("Enter the Social Mark="))
total=int
sumof=int
sumof=e+t+m+sci+soc;
total=sumof/5.0;
print("total=",sumof)
print("Average=",total)
if(total>=75):
   print("Distinction")
elif(total>=60):
   print("First Class")
elif(total>=50):
   print("Second Class")
elif(total<=40):
   print("Fail")
 