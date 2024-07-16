ar=[20,5,90,23]
sl=0
l=0
for i in range(0,len(ar)):
    if ar[i]>l:
        sl=l
        l=ar[i]
    elif ar[i]>sl:
        sl=ar[i]
print("Second Largest=",sl)
        