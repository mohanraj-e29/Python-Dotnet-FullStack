function valid()
{
//name
v1=document.getElementById("bx1");
e1=document.getElementById("er1");
exp1=/^[a-z A-Z]{3,20}$/;
if(v1.value=="")
{
	e1.innerText="please enter your name";
	v1.focus();
	return false;
}
else if(exp1.test(v1.value)==false)
{
	e1.innerText="invalid name";
	v1.focus();
	return false;
}
else
{
	e1.innerText="correct";
}
//phone
v2=document.getElementById("bx2");
e2=document.getElementById("er2");
exp2=/^[6-9]{1}[0-9]{9}$/;
if(v2.value=="")
{
	e2.innerText="please enter your phone number";
	v2.focus();
	return false;
}
else if(exp2.test(v2.value)==false)
{
	e2.innerText="invalid phno";
	v2.focus();
	return false;
}
else
{
	e2.innerText="";
}
//gender
v3=document.getElementsByName("gender");
e3=document.getElementById("er3");
if(v3[0].checked==false && v3[1].checked==false)
{
	e3.innerText="please enter your gender";
	return false;
}
else
{
	e3.innerText="";
}
//skills
v4=document.getElementsByClassName("skills");
e4=document.getElementById("er4");
cnt=0;
for(i=0;i<v4.length;i++)
{
	if(v4[i].checked==true)
	{
		cnt++;
	}
}
if(cnt<2)
{
	e4.innerText="please choose atleast 2 skills";
	return false;
}
else
{
	e4.innerText="";
}
//dept
v5=document.getElementById("bx5");
e5=document.getElementById("er5");
sel=v5.selectedIndex;
if(sel==0)
{
	e5.innerText="please select your department";
	return false;
}
else
{
	e5.innerText="";
}
}