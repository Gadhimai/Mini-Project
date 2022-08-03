select * from AspNetUsers

select * from AspNetUserClaims

insert into AspNetUserClaims values('392bb8fb-4eaa-4203-9745-09982dd60a5f', 'Position', 'Admin')
insert into AspNetUserClaims values('d6b59057-27d4-4df3-b82e-78eae7537b5a', 'Position', 'Cashier')

delete from AspNetUserClaims where id = 2
delete from AspNetUserClaims where id = 3
