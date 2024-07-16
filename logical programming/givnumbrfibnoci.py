n=int(input("enter the number="))
c=0
a=1
b=1
if(n==0 or n==1):
    print("fibonaci")
else:
    while(c<n):
        c=a+b
        b=a
        a=c
    if(c==n):
        print("Fibonaci")
    else:
        print("Not a fibonaci")