# WindowsFormsAnimation
-----

[NuGet Packages](https://www.nuget.org/packages/HackerPwd/)
<br/>
.NET Framework 4.7.2

# A DLL
-----

A biblioteca é grátis para uso comercial ou não comercial.
<br/>
Gerador de combinações de senhas 

# COMBINAÇÕES
-----
1. NÚMEROS
2. CARACTERES SIMPLES
3. CARACTERES COM ACENTO
4. CARACTERES ESPECIAIS
5. COMBINAÇÕES ENTRE TODOS 

# USANDO
-----

1. Instale a biblioteca pelo pacote NuGet Packages;
2. Crie a classe HackerPwd;
```cs
private HackerPwd.Passwords Passwords { get; set; }
this.Passwords = new HackerPwd.Passwords();
```
3. Informe o tipo e o minimo e máximo de caracteres;
```cs
Passwords.MinimumChar = Convert.ToInt32(txtMinimo.Value);
            Passwords.MaximumChar = Convert.ToInt32(txtMaximo.Value);

            switch (chbFiltro.SelectedIndex)
            {
                case 0:
                    Passwords.Types = HackerPwd.Enums.Types.NUMBER;
                    break;
                case 1:
                    Passwords.Types = HackerPwd.Enums.Types.CHAR;
                    break;
                case 2:
                    Passwords.Types = HackerPwd.Enums.Types.CHAR_ACENTO;
                    break;
                case 3:
                    Passwords.Types = HackerPwd.Enums.Types.ESPECIAL;
                    break;
                case 4:
                    Passwords.Types = HackerPwd.Enums.Types.NUMBEReCHAR_ACENTO;
                    break;
                case 5:
                    Passwords.Types = HackerPwd.Enums.Types.NUMBEReESPECIAL;
                    break;
                case 6:
                    Passwords.Types = HackerPwd.Enums.Types.CHAReCHAR_ACENTO;
                    break;
                case 7:
                    Passwords.Types = HackerPwd.Enums.Types.CHAReESPECIAL;
                    break;
                case 8:
                    Passwords.Types = HackerPwd.Enums.Types.CHAR_ACENTOeESPECIAL;
                    break;
                case 9:
                    Passwords.Types = HackerPwd.Enums.Types.NUMBEReCHAReCHAR_ACENTO;
                    break;
                case 10:
                    Passwords.Types = HackerPwd.Enums.Types.NUMBEReCHAReESPECIAL;
                    break;
                case 11:
                    Passwords.Types = HackerPwd.Enums.Types.NUMBEReCHAR_ACENTOeESPECIAL;
                    break;
                case 12:
                    Passwords.Types = HackerPwd.Enums.Types.CHAReCHAR_ACENTOeESPECIAL;
                    break;
                case 13:
                    Passwords.Types = HackerPwd.Enums.Types.ALL;
                    break;
                default:
                    Passwords.Types = HackerPwd.Enums.Types.NUMBEReCHAR;
                    break;
            }
```
4. Use o Start() para iniciar a busca;
```cs
Passwords.Start()
```

# EVENTOS
-----

1. ReceiveIndividually é executado toda vez que gera uma combinação de senha;
```cs
private void Passwords_ReceiveIndividually(object sender, EventArgs e)
        {
            lblSenha.Text = sender.ToString();
            lblSenha.Refresh();
        }
```

# COMANDOS
-----

1. Use o START para iniciar ou reinicar a entrega de combinações;
```cs
Passwords.Commands = HackerPwd.Enums.Commands.START;
```
2. Use o BREAK para pausar a qualquer momento a entrega de combinações;
```cs
Passwords.Commands = HackerPwd.Enums.Commands.BREAK;
```
3. Use o CANCEL para cancelar a qualquer momento a entrega de combinações;
```cs
Passwords.Commands = HackerPwd.Enums.Commands.CANCEL;
```

# SUPORTE
-----

[**Siga-me**](https://github.com/pinalrafael?tab=followers) para minhas próximas criações