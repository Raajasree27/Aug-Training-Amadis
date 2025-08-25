create procedure transfer_money
	@fromacc int,
	@toacc int,
	@amount decimal(10,2)
as
begin
	begin try
		begin transaction
			if(select balance from accounts where accountID=@fromacc)<@amount
			begin
				throw 50001, 'Insufficient balance',1;
			end
			update accounts set balance=balance-@amount where accountID=@fromacc;

			save transaction beforecredit;

			update accounts set balance =balance + @amount where accountID=@toacc;

		commit transaction;
		print 'Transfer Completed Successfully';
	end try
	begin catch
		print 'Transaction Failed'+Error_message();
	end catch
end;

drop procedure transfer_money;

EXEC transfer_money @fromacc = 2, @toacc = 5, @amount = 1000.00;

 

