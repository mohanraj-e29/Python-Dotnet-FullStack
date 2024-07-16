def sum(n):
     if n==0:
        return 0
     return(n%10+sum(int(n/10)))
     
n=123
r=sum(n)
print("Sum=",r)