n=int(input("Enter The Number:"))
n1=[]
while(n>0):
  r=n%10
  n1.append(r)
  n=n//10
n1.sort()
print(n1)
       