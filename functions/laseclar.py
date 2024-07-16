n=[1,2,3,4,5,6,7,8,9]
def larinfo():
   global n
    max=n[0]
    for i in n:
        if(i>max):
            max=i
print("The largest number=",max)
def secinfo():
global n
     min=n[0]
     for i in n:
        if i>min:
         min=i
print("The largest number=",max)
   
larinfo()
secinfo()