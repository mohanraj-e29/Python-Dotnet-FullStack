l=[2,5,6,8,47,9]
print("Original list=",l)
for i in range(0,len(l)):
    for j in range(i+1,len(l)):
        if(l[i]>l[j]):
         t=l[i]
         l[i]=l[j]
         l[j]=t
print("ascending=",l)
