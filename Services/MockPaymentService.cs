using System;

namespace BaseballShop.Services
{
    public class MockPaymentService
    {
        public string ProcessPayment(decimal amount, string currency)
        {
            // Simulate payment processing delay
            System.Threading.Thread.Sleep(1000);

            // Generate a fake transaction ID
            string transactionId = Guid.NewGuid().ToString();

            // Simulate success or failure (90% success rate)
            bool isSuccessful = new Random().Next(1, 10) <= 9;

            return isSuccessful ? $"Success: Transaction ID {transactionId}" : "Payment Failed!";
        }
    }
}