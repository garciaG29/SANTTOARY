using Microsoft.JSInterop;

namespace Santtoary_.WEB.Services;

public class SessionService
{
    private readonly IJSRuntime _js;

    public SessionService(IJSRuntime js)
    {
        _js = js;
    }

    public event Action? OnChange;

    public async Task SaveToken(string token)
    {
        await _js.InvokeVoidAsync("localStorage.setItem", "token", token);
        OnChange?.Invoke();
    }

    public async Task<string?> GetToken()
    {
        return await _js.InvokeAsync<string>("localStorage.getItem", "token");
    }

    public async Task Logout()
    {
        await _js.InvokeVoidAsync("localStorage.removeItem", "token");
        OnChange?.Invoke();
    }
}