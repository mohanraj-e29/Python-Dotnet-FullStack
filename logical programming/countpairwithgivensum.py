ar=[1,5,7,-1]
n=len(ar)
k=6
c=0
for i in range(0,n):
    for j in range(i+1,n):
        if(ar[i]+ar[j]==k):
            c+=1
print("C=",c)
