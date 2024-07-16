bill=int(input("Enter The Bill Amount="))
Gst=float(4.5)
gstamount=(bill*Gst)/100
print("GST=",gstamount)
totalamount=bill+gstamount
print("Total Amount=",totalamount)
amtpaid=int(input("Paying Amount="))
print("Amount paid=",amtpaid)
balance=amtpaid-totalamount;
print("Balance=",balance)
