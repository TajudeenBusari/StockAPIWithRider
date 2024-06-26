using Stock.API.Models;

namespace Stock.API.Interfaces;

public interface IPortfolioRepository
{
    Task<List<Models.Stock>> GetUserPortfolio(AppUser user);
    Task<Portfolio> CreateUserPortfolioAsync(Portfolio portfolio);
    Task<Portfolio> DeleteUserPortfolioAsync(AppUser appUser, string symbol);
}