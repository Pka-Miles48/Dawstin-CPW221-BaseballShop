using System;
using Dawstin_CPW221_BaseballShop.Models;
using Dawstin_CPW221_BaseballShop.Baseball_Data;

namespace Dawstin_CPW221_BaseballShop.Services
{
    /// <summary>
    /// Simulates a payment processing service for transactions in the Baseball Shop.
    /// </summary>
    public class MockPaymentService
    {
        /// <summary>
        /// Processes a mock payment transaction.
        /// </summary>
        /// <param name="amount">The amount to be processed.</param>
        /// <param name="currency">The currency type for the transaction.</param>
        /// <returns>
        /// A message indicating success or failure, including a transaction ID if successful.
        /// </returns>
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