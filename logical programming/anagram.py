s1="python"
si=list(s1)
s2="nohtyp"
sl=list(s2)
for i in range(0,len(si)):
    for j in range(i+1,len(si)):
        t=si[i]
        si[i]=si[j]
        si[j]=t
for k in range(0,len(sl)):
    for l in range(i+1,len(sl)):
        t=sl[k]
        sl[k]=sl[l]
        sl[l]=t
if(si==sl):
    print("Anagram")
else:
    print("Not a Anagram")