from csv import*
f=open("userinfo.csv","r")
c=reader(f)
for i in c:
    for j in i:
        print(j,end="\t")
    print()
f.close()    