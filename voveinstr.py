n=input("Enter The String:")
vowel=('a','e','i','o','u','A','E','I','O','U')
r=''
for i in n:
    if(i not in vowel):
        r=r+i
print(r)     