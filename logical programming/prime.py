def prime(n):
    c=0
    for i in range (1,n+1):
        if(n%i==0):
            c+=1
    if(c==2):
        print(n)
        
        
l1=[1,2,3,4,5,6,7,8,9,10,11]
print("prime numbers are=")

                