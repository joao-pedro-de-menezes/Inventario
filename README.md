# Sistema de Gestão de Equipamentos e Licenças - Empreenda Senac

## 🛠 Visão Geral
Este sistema foi desenvolvido originalmente para ambiente Web e migrado para **Windows Forms (.NET Framework 4.7.2)** com foco em robustez e performance para gestão de inventário de agricultura de precisão (pilotos automáticos para tratores e colheitadeiras).

O software permite o controle total de ativos, monitoramento de vencimento de licenças e gestão de manutenção, utilizando **SQL Server** como motor de banco de dados.

---

## 💻 Especificações Técnicas
- **Plataforma:** Windows Forms (WinForms)
- **Framework:** .NET Framework 4.7.2
- **Linguagem:** C#
- **Banco de Dados:** SQL Server
- **Arquitetura:** Camadas (UI, Business Logic e Data Access)

---

## 🏗 Divisão de Telas e Requisitos (Módulos do Sistema)

Abaixo estão detalhados os requisitos de interface e comportamento, adaptados para componentes Windows Forms.

### 1. Núcleo de Acesso (Autenticação)
- **FormLogin:** - Controles: `TextBox` (Usuario/Senha), `Button` (Login/Cadastrar).
    - Comportamento: Validação de hash de senha no SQL Server.
- **FormCadastroUsuario (Modal):**
    - Acesso: Botão de cadastro inicial ou menu Configurações.
    - Campos: Nome, E-mail, Crachá, Senha.

### 2. Interface Principal (Dashboard & Navegação)
- **FormMain (MDI Container):**
    - **Barra de Status (`StatusStrip`):** Exibe `lblUsuarioLogado` e `btnLogoff`.
    - **Troca de Tema:** Implementação de lógica para alternar `BackColor` e `ForeColor` entre Dark/Light Mode.
    - **Menu Principal (`MenuStrip`):** - Dashboard
        - Cadastro (Equipamento, Licenças, Máquinas)
        - Configurações (Usuário, Tipo Equipamento)

### 3. Módulos de Cadastro (Telas Gerenciais)

Cada tela de cadastro segue o padrão: **Toolbar (`ToolStrip`)** + **Grade (`DataGridView`)** + **Formulário de Edição (`Form Modal`)**.

#### A. Gestão de Equipamentos
- **Campos Específicos:** Descrição, Nº Série (Máscara: Caixa Alta/Alfanumérico), Data de Renovação, NAV, TM 200, Antena AG25, etc.
- **Lógica de Negócio:** O campo "Vencimento" é calculado automaticamente via código C# baseado no tipo de renovação da licença.
- **Vinculação:** ComboBoxes carregadas dinamicamente com dados de "Máquinas" e "Tipos de Equipamento".

#### B. Gestão de Licenças
- **Funcionalidade:** Controle financeiro e temporal de softwares/licenças.
- **Campos:** Equipamento vinculado, Valor da Licença (formatação monetária), Vencimento, Data do Orçamento.

#### C. Cadastro de Máquinas
- **Funcionalidade:** Registro da frota física.
- **Campos:** ID (Auto-incremento SQL), Placa, Frota, Status (Ativo/Inativo via `CheckBox`).

### 4. Configurações de Sistema
- **Tipo de Equipamento:** Define se o equipamento exige ou não controle de licença (afeta o comportamento do Form de Equipamento).
- **Gestão de Usuários:** Administração de permissões e perfis de acesso.

---

## 📊 Dashboard (Indicadores em Tempo Real)
O Dashboard WinForms utiliza consultas agregadas (`SUM`, `COUNT`) no SQL Server para exibir:
1. Total de máquinas com piloto instalado.
2. Alerta visual para **Licenças Vencidas** (Destaque em Vermelho).
3. Alerta para **Vencimentos em 30 dias** (Destaque em Amarelo).
4. Status de manutenção (Equipamentos externos/danificados).

---

## 🗄 Estrutura do Banco de Dados (SQL Server)
*O script de criação das tabelas (`.sql`) encontra-se na pasta /Database.*

Principais Tabelas:
- `Usuarios` (ID, Nome, Email, SenhaHash, Crachá, Cargo, Ativo)
- `Equipamentos` (ID, Descricao, TipoID, Serie, MaquinaID, Local, Observacoes...)
- `Licencas` (ID, EquipamentoID, Modelo, Serie, Valor, DataVencimento...)
- `Maquinas` (ID, Descricao, Placa, Frota, Ativo)
- `TiposEquipamento` (ID, Descricao, ExigeLicenca, Ativo)

---

