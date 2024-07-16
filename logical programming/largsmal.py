li=[2,5,6,8,47,9]
maxi=mini=li[0]
for i in range(0,len(li)):
    if(li[i]>maxi):
        maxi=li[i]
    if(li[i]<mini):
        mini=li[i]      
print("Max=",maxi)
print("Mini=",mini)
