## Testes using Xunit no vscode.
    É necessário inserir testes no código para que verifique que não haja erros nas variáveis.

1 - Instalar extensão "NuGet Package Manager"
2 - CTRL+SHIFT+P > NuGet Package Manager > pesquisar pelo pacote e instalar a versão desejada.
3 - Salvar o projeto após instalar todas dependencias
4 - Ao rodar "dotnet build" vai dar um erro pois foi adicionado um novo entrypoint sdk e não será mais o main.
5 - Para corrigir o erro: adicionar a linha abaixo dentro do "xyz.csproj" > dentro de <PropertyGroup>
    <GenerateProgramFile>false</GenerateProgramFile>
6 - Salvar novamente e rodar o build

Neste caso as extensões que instalei utilizando sempre a ultima versão foram:
  <ItemGroup>
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.1.0-preview-20211130-02"/>
    <PackageReference Include="xunit" Version="2.4.2-pre.12"/>
    <PackageReference Include="xunit.runner.visualstudio" Version="2.4.3"/>
  </ItemGroup>

7 - Criar um novo arquivo, ex.: testclass.cs
    esse arquivo irá testar a variável com um valor que vc definir para rodar durante o teste e identificar possíveis falhas.
8 - Deixei com erro no meu testclass.cs para que pudesse servir de exemplo!