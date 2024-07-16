n=121
d=n
s=0
while(n>0):
    r=n%10
    n=n//10
    s=s*10+r
if(d==s):
    print("Palindrome")
else:
    print("Not a palindrome")