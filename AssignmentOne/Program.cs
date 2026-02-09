double billAmount;
Console.Write("Please Enter The BillAmount:");
billAmount = Convert.ToDouble(Console.ReadLine());
if (billAmount >= 500)
    billAmount = billAmount - (billAmount * .2);
else if (billAmount > 300 & billAmount <= 499)
    billAmount = billAmount - (billAmount * .1);
else
    Console.WriteLine("No Discount Was Applied The Invoice");

Console.WriteLine($"Final Price : {billAmount}");
