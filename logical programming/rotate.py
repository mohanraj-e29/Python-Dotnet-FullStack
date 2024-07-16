def rotate(arr,d,n):
    arr[:]=arr[d:n]+arr[0:d]
    return arr
    
arr=[1,2,3,4,5]
print("rotate=")
print(rotate(arr,1,len(arr)))
    
def sumseries(n):
    f=0
    re=0
    for i in range(1,n+1):
        f=f*i
        re=re+(i/f)
        return re
        
print(sumseries(5))