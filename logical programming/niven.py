n=18
s=n
su=0
while(n>0):
    r=n%10
    n=n//10
    su=su+r
if(s%su==0):
    print("Niven")
else:
    print("Not a niven number")