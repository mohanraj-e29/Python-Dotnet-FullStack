n=str(input("Enter the String:"))
l=len(n)
for i in(l):
     c=0
     for j in (l):
        if(str[i]==str[j] and i!=j):
          c=1
          break
     if(c==0):
         print("non repeating character is=",n[i])
     if(c==1):
         print("repeating character is=",n[i])