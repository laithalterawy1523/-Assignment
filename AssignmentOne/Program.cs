string billAmount;
Console.Write("Please Enter The BillAmount:");
billAmount = Console.ReadLine();
double BillAmount = Convert.ToDouble(billAmount);
if (BillAmount >= 500)
    BillAmount = BillAmount - (BillAmount * .2);
else if (BillAmount > 300 & BillAmount <= 499)
    BillAmount = BillAmount - (BillAmount * .1);
else
    Console.WriteLine("No Discount Was Applied The Invoice");

Console.WriteLine($"Final Price : {BillAmount}");
//change