from pymysql import *
def add():
    try:
        name = input("Enter the Name :")
        age = int(input("Enter the Age :"))
        loc = input("Enter the Location :")
        con = connect(host="localhost",user="root",password="",database="user10")
        q = "insert into person values('{0}',{1},'{2}')".format(name,age,loc)
        c = con.cursor()
        c.execute(q)
        con.commit()
        con.close()
        print("Data Saved....")
    except Exception as e:
        print(e)

def update():
    try:
        name = input("Enter the Name :")
        age = int(input("Enter the Age :"))
        con = connect(host="localhost",user="root",password="",database="user10")
        q = "update person set age ={0} where name ='{1}'".format(age,name)
        c = con.cursor()
        r=c.execute(q)
        con.commit()
        con.close()
        print("Data updated" if(r!=0) else "Invalid Name")
    except Exception as e:
        print(e)
def delete():
    try:
        name = input("Enter the Name :")
        con = connect(host="localhost",user="root",password="",database="user10")
        q = "delete from person where name ='{0}'".format(name)
        c = con.cursor()
        r=c.execute(q)
        con.commit()
        con.close()
        print("Data deleted" if(r!=0) else "Invalid Name")
    except Exception as e:
        print(e)
def find():
    try:
        name = input("Enter the Name :")
        con = connect(host="localhost",user="root",password="",database="user10")
        q = "select * from person where name='{0}'".format(name)
        c = con.cursor()
        c.execute(q)
        result = c.fetchall()
        print("name\tage\tlocation")
        for i in result:
            for j in i:
                print(j,end="\t")
            print()
        con.close()
    except Exception as e:
        print(e)
def printData():
    try:        
        con = connect(host="localhost",user="root",password="",database="user10")
        q = "select * from person"
        c = con.cursor()
        c.execute(q)
        result = c.fetchall()
        print("name\tage\tlocation")
        for i in result:
            for j in i:
                print(j,end="\t")
            print()
        con.close()
    except Exception as e:
        print(e)
ch = int(input("1.add\n2.update\n3.delete\n4.find\n5.print\nselect any 1:"))
if(ch==1):
    add()
elif(ch==2):
    update()
elif(ch==3):
    delete()
elif(ch==4):
    find()
elif(ch==5):
    printData()
else:
    print("Invalid choice...")