

namespace Dio.Async.Programming;

internal class Cozinha
{
    public async void FazerComida()
    {
        await Task.WhenAll(FritandoOvoAsync(), CozinhaArrozAsync());
    }

    private void FritarOvo()
    {
        Console.WriteLine("Fritando ovo");
        Thread.Sleep(5000);
        Console.WriteLine("Ovo frito");
    }

    private void CozinhaArroz()
    {
        Console.WriteLine("Cozinhando arroz");
        Thread.Sleep(10000);
        Console.WriteLine("Arroz cozido");
    }

    public async Task FazerComidaAsync()
    {
        await FritandoOvoAsync();
        await CozinhaArrozAsync();
    }

    private async Task CozinhaArrozAsync()
    {
        await Console.Out.WriteLineAsync("Cozinhando arroz");
        await Task.Delay(10000);
        await Console.Out.WriteLineAsync("Arroz cozido");
    }

    private async Task FritandoOvoAsync()
    {
        await Console.Out.WriteLineAsync("Fritando ovo");
        await Task.Delay(5000);
        await Console.Out.WriteLineAsync("ovo frito");
    }
}
