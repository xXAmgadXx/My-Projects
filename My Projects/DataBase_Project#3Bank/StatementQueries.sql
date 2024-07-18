select top 1 Branch_number from Branch where Branch_number not in (select Branch_number from Account union select Branch_number from Loan)

select top 1 Branch_number from Branch where Branch_number not in (select Branch_number from Employee)

select top 1 Em_ID, count(Em_ID) mycount from Loan group by Em_ID order by mycount desc 

select top 1 SSN, count(SSN) mycount from Loan group by SSN order by mycount desc 

select top 1 SSN from Customer where SSN not in (select SSN from Loan)

select Customer.*, count(EC.SSN) as employeeCount from Customer left join EC on Customer.SSN=EC.SSN group by Customer.SSN, Customer.Name, Customer.Address, Customer.Phone, Customer.username, Customer.password