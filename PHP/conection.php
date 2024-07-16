<?php
//$servername="localhost";
//$username="username";
//$password="password";

//create connection
$link= mysql_connect('localhost','mysql_user','mysql_password');

//check connection
if(!$link)
{
	die('could not connct:'.mysql_error());
}
echo "connected successfully";
mysql_close($link);

?>
