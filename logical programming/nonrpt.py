a=[2,3,5,6,2,4]
n=len(a)
c=0
j=0
for i in range(n):
    if a[i]==a[j]:
        c+=1 
    elif(c==n):
        print(a[i])
        