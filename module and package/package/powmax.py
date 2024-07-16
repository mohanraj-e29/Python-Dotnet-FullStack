def power():
    b=int(input("Enter the base value="))
    p=int(input("Enter the power value="))
    ans=b**p
    print("Power of given value=",ans)
    print("----------------------------------------------------------------------")
def maxin():
    n=[1,2,3,4]
    maxi=n[0]
    for i in range(len(n)):
        if(n[i]>maxi):
            maxi=n[i]
    print("maximum number=",maxi)
    
    
