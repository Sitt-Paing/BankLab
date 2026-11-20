# Banking System Engineering — ၁၆ ပတ်စာ လေ့လာရေး Roadmap

Banking Academy Lesson 1 ရဲ့ ဘဏ်လုပ်ငန်းအခြေခံနဲ့ Lesson 2 ရဲ့ double-entry accounting ကို ဆက်ပြီး C#၊ ASP.NET Core၊ EF Core၊ SQL Server၊ Angular နဲ့ PrimeNG သုံးကာ ဘဏ်လုပ်ငန်းစနစ်တစ်ခု တည်ဆောက်မယ်။ စာရင်းသွင်းချက်ကို လက်နဲ့တွက်ရာကနေ database ထဲ စစ်ဆေးခြင်း၊ ငွေလွှဲပြိုင်တူဝင်ခြင်း၊ settlement စာရင်းတိုက်ခြင်းနဲ့ staging deployment အထိ သွားမယ်။

**အချိန်** ၁၆ ပတ် × ၁၈ နာရီ = **၂၈၈ နာရီ**  
**ကြိုတင်သိထားသင့်တာ** C# class/async၊ HTTP/JSON၊ SQL JOIN/aggregate၊ TypeScript နှင့် Git အခြေခံ။ ပထမပတ်မှာ API တစ်ခု run လုပ်၊ SQL query တစ်ခုရေး၊ Angular မှာ JSON ပြနိုင်ခြင်းဖြင့် အခြေခံစစ်ပါ။  
**Capstone** BankLab ဆိုတဲ့ single-currency retail banking simulator။ ဖန်တီးထားသော customer data၊ test balance၊ mock payment provider နဲ့ staging environment ကို သုံးပါ။ FX၊ loan servicing၊ card network integration နဲ့ jurisdiction အလိုက် စည်းမျဉ်းအကောင်အထည်ဖော်ခြင်းကို နောက်ဆက်တွဲအဖြစ်ထားပါ။

## အပတ်စဉ် အချိန်ဇယား

| ရက် | နာရီ | လုပ်ရမည့်အရာ |
|---|---:|---|
| တနင်္လာ | 3 | သီအိုရီဖတ်၊ မိမိစကားဖြင့် အဓိပ္ပာယ်ပြန်ရေး |
| အင်္ဂါ | 3 | လုပ်ငန်းစဉ်၊ စာရင်းသွင်းချက်၊ state transition ဆွဲ |
| ဗုဒ္ဓဟူး | 3 | Lab တည်ဆောက် |
| ကြာသပတေး | 3 | Lab ဆက်လုပ်၊ database နဲ့ UI ချိတ် |
| စနေ | 4 | Automated tests၊ အမှားဖြစ်စေပြီး recovery စမ်း |
| တနင်္ဂနွေ | 2 | Demo၊ evidence link၊ အပတ်စဉ် ပြန်လည်သုံးသပ်ချက် |
| **စုစုပေါင်း** | **18** | |

အပတ်တိုင်း **ဖတ် → လက်နဲ့တွက်/ပုံဆွဲ → build → test → ရလဒ်ပြ** လို့ လုပ်ပါ။ Acceptance criteria မပြည့်သေးရင် tracker မှာ evidence နဲ့ ကျန်တဲ့အချက်ကို ရေးပြီး အဲဒီအပေါ် မှီခိုတဲ့ lab မစခင် ဖြည့်ပါ။

## .NET အခြေခံနှင့် .NET 11 အသစ်များကို Documentation နဲ့တွဲလေ့လာခြင်း

BankLab backend project ၄ ခုလုံးက `net11.0` ကို target လုပ်တယ်။ C# 15 က ဒီ target ရဲ့ မူလ language version ပါ။ အောက်ကစာတွေကို သက်ဆိုင်ရာအပတ်ရဲ့ ၃ နာရီစာ သီအိုရီချိန်ထဲမှာ ဖတ်ပြီး ရလဒ်ကို အဲဒီအပတ်ရဲ့ lab နဲ့ acceptance checks ထဲ ထည့်ပါ။ အပတ်စဉ် ၁၈ နာရီ အစီအစဉ်အတိုင်း သွားပါမယ်။

### .NET 10 ခေတ်အထိ ရှိပြီးသား အခြေခံများ

အပတ်စဉ် lab ကို အောက်က အခြေခံနည်းလမ်းနဲ့ အရင်လုပ်ပါ။ Lab ကို BankLab ရဲ့ .NET 11 SDK နဲ့ပဲ run ပါ။ Release နှစ်ခု ဘာကွာလဲ ကြည့်ချင်ရင် overview နှစ်ခုကို တွဲဖတ်ပါ။ [What's new in .NET 10](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-10/overview) · [What's new in .NET 11](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-11/overview)

| ပတ် | အရင်လေ့လာရမည့်အခြေခံ | ဖတ်ရန် | BankLab မှာ စမ်းရန် |
|---|---|---|---|
| **01** | Solution၊ project references၊ dependency injection | [dotnet sln](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-sln) · [ASP.NET Core dependency injection](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-10.0) | `dotnet sln src/BankLab.slnx list` run ပြီး project ၄ ခုကို ကြည့်ပါ။ `IJournalStore` ကို Application မှာ သတ်မှတ်၊ Infrastructure မှာ implement၊ Api မှာ register လုပ်မယ့် အကြောင်းကို diagram ဆွဲပါ။ |
| **02** | C# classes၊ records၊ value equality နှင့် ငွေပမာဏ | [C# record types](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/records) · [Floating-point numeric types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types) | `JournalEntry` ကို class အဖြစ်၊ `Money` ကို amount နှင့် currency ပါသည့် value object အဖြစ် model လုပ်ပါ။ တန်ဖိုးတူ `Money` နှစ်ခု ညီပြီး debit/credit မညီတဲ့ entry ကို ပယ်နိုင်ကြောင်း စစ်ပါ။ |
| **04၊ 07** | DbContext၊ migrations၊ SQL transaction နှင့် optimistic concurrency | [EF Core DbContext](https://learn.microsoft.com/en-us/ef/core/dbcontext-configuration/) · [Migrations](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/applying) · [Transactions](https://learn.microsoft.com/en-us/ef/core/saving/transactions) · [Concurrency](https://learn.microsoft.com/en-us/ef/core/modeling/concurrency) | ပတ် ၄ မှာ journal ကို database ထဲ ရေးပြီး rollback စမ်းပါ။ ပတ် ၇ မှာ `rowversion` နဲ့ ပြိုင်တူငွေလွှဲ နှစ်ခုထဲက တစ်ခုသာ post ဖြစ်တာ စစ်ပါ။ |
| **05** | Controllers၊ HTTP status၊ request/response DTO၊ `async/await` | [ASP.NET Core Web APIs](https://learn.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-10.0) · [C# async/await](https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/) | `POST /api/transfers` မှာ success receipt နဲ့ rejection response ကို သီးခြား test လုပ်ပါ။ API request ရဲ့ cancellation token ကို EF Core async query ဆီ ဆက်ပို့ပါ။ |
| **10** | SQL JOIN၊ LINQ grouping နှင့် reconciliation match key | [LINQ join operations](https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/join-operations) · [SQL Server FROM နှင့် JOIN](https://learn.microsoft.com/en-us/sql/t-sql/queries/from-transact-sql) | SQL `FULL OUTER JOIN` ကို fixture နှစ်ခုနဲ့ နားလည်အောင် အရင်စမ်းပါ။ Matched၊ internal-only၊ external-only ရလဒ်တွေကို မှတ်ထားပြီး LINQ `FullJoin` ရလဒ်နဲ့ တိုက်ပါ။ |
| **15** | Unit tests၊ ASP.NET Core integration tests နှင့် build baseline | [Unit testing in .NET](https://learn.microsoft.com/en-us/dotnet/core/testing/) · [ASP.NET Core integration tests](https://learn.microsoft.com/en-us/aspnet/core/test/integration-tests) | Journal rule ကို unit test၊ transfer endpoint ကို integration test နဲ့ စစ်ပါ။ စမ်းသပ်မှုရလဒ်နဲ့ clean build အချိန်ကို rehearsal report မှာ မှတ်ပါ။ |

### .NET 11 နှင့် C# 15 မှာ အသစ်ထွက်တာများ

အခြေခံ lab ရလဒ် ရပြီးရင် အောက်က feature ကို သက်ဆိုင်ရာအပတ်မှာ စမ်းပါ။ Documentation ရဲ့ version ကို ကြည့်ပြီး code နမူနာကို ကိုယ်ရေးထားတဲ့ BankLab flow နဲ့ တိုက်ပါ။

| ပတ် | Documentation | Lab ထဲမှာ စမ်းရန် | စစ်ဆေးရမည့် ရလဒ် |
|---|---|---|---|
| **01 · SDK နှင့် Solution** | [Microsoft .NET 11 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/11.0) · [What's new in .NET 11](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-11/overview) | BankLab root ကနေ `dotnet --version` နဲ့ `dotnet build src/BankLab.slnx` run ပါ။ | သုံးခဲ့တဲ့ SDK version ကို setup notes ထဲ ရေးပါ။ Solution ထဲ project ၄ ခုလုံး `net11.0` နဲ့ build အောင်ရမယ်။ |
| **02 · ငွေပမာဏနှင့် decimal** | [Microsoft .NET 11 numeric conversion changes](https://learn.microsoft.com/en-us/dotnet/core/compatibility/core-libraries/11/decimal-biginteger-floating-point-conversions) | Console lab မှာ `(decimal)1.23` နဲ့ `1.23m` ကို နှိုင်းယှဉ်ပါ။ API amount စာသား `"1.23"` ကို `decimal` အဖြစ် တိုက်ရိုက် parse လုပ်ပြီး fixture journal မှာ သုံးပါ။ | Parse တန်ဖိုး `1.23m` နဲ့ ညီရမယ်။ API contract မှာ သတ်မှတ်ထားတဲ့ decimal places ထက်ပိုရင် ပယ်ပြီး ပတ် ၂ trial balance စစ်ဆေးချက်တွေ ဖြတ်ရမယ်။ |
| **04 · EF Core 11 နှင့် SQL Server** | [What's new in EF Core 11](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-11.0/whatsnew) · [Applying EF Core migrations](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/applying) | Infrastructure ရဲ့ SQL Server provider နဲ့ EF migration tooling ကို 11.x သုံးပါ။ Initial migration နဲ့ statement index migration ကို စမ်းပါ။ | အသစ်ဖန်တီးထားတဲ့ database နဲ့ ရှိပြီးသား database အဆင့်မြှင့်တာ နှစ်ခုလုံး အောင်ရမယ်။ Applied migrations နဲ့ fixture row count ကို မှတ်ပါ။ |
| **05 · C# 15 union types နှင့် transfer result** | [What's new in C# 15](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-15) · [Microsoft .NET 11 release notes](https://devblogs.microsoft.com/dotnet/announcing-dotnet-11/) | Transfer use case ရဲ့ ရလဒ်ကို `TransferPosted`၊ `InsufficientFunds` စတဲ့ သီးခြား union cases နဲ့ lab ထဲမှာ ဖော်ပြပါ။ API မှာ case တစ်ခုချင်းစီကို သက်ဆိုင်ရာ HTTP response သို့ map ပြီး generated OpenAPI document ကို ကြည့်ပါ။ | Case တစ်ခုကို `switch` ကနေ ခဏဖယ်ပြီး compiler သတိပေးချက်ကို ကြည့်ပါ။ ပြီးရင် ပြန်ထည့်ပြီး success receipt နဲ့ rejection response ကို API test နဲ့ စစ်ပါ။ |
| **10 · LINQ FullJoin နှင့် reconciliation** | [EF Core 11 FullJoin translation](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-11.0/whatsnew#support-for-the-new-net-11-fulljoin-operator) | Payment records နဲ့ normalize လုပ်ထားတဲ့ statement lines ကို match key နဲ့ `FullJoin` လုပ်ပါ။ `ToQueryString()` နဲ့ SQL ကြည့်ပြီး SQL Server fixture မှာ run ပါ။ | SQL ထဲမှာ `FULL JOIN` ပါပြီး matched၊ internal-only၊ external-only သုံးမျိုးလုံး ရရမယ်။ Duplicate သို့ ambiguous keys ကို exception အဖြစ် ပတ် ၁၀ ရဲ့ စည်းမျဉ်းအတိုင်း စစ်ပါ။ |
| **15 · Runtime နှင့် build performance** | [Microsoft .NET 11 runtime နှင့် SDK overview](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-11/overview) · [Performance Improvements in .NET 11](https://devblogs.microsoft.com/dotnet/performance-improvements-in-net-11/) | JIT optimization၊ Runtime Async သို့ CLI startup ပြောင်းလဲမှု တစ်ခု ရွေးဖတ်ပါ။ Setup တူတူမှာ clean build နဲ့ incremental build ကို သီးခြားတိုင်းပါ။ | SDK version၊ command၊ စမ်းသပ်ရလဒ်နဲ့ တိုင်းတာမှုအခြေအနေကို rehearsal report ထဲ မှတ်ပါ။ .NET version နှစ်ခုရဲ့ performance ကို ယှဉ်မယ်ဆို workload နဲ့ build mode တူရမယ်။ |

OpenAPI 3.2 က ASP.NET Core 11 ရဲ့ default ပါ။ Async validation ကို လေ့လာချင်ရင် release notes ထဲက Minimal API နမူနာကို ပတ် ၅ မှာ သီးခြားစမ်းနိုင်ပါတယ်။ BankLab transfer API ရဲ့ လက်ကျန်နဲ့ ခွင့်ပြုချက်စစ်တဲ့ logic ကို use case နဲ့ သက်ဆိုင်ရာ transaction ထဲမှာ ထားပါ။

## InventoryManagementSystem ကို နမူနာယူမည့် BankLab Setup

[InventoryManagementSystem repository](https://github.com/Sitt-Paing/InventoryManagementSystem) ရဲ့ `Program.cs`၊ `launchSettings.json`၊ `DependencyInjection.cs` နဲ့ README ကို နမူနာယူပါ။ ဆန်းစစ်ထားတဲ့ checkout က `b1e9f659` ဖြစ်ပါတယ်။ BankLab project က `net11.0` သုံးတဲ့အတွက် framework packages နဲ့ EF tooling ကို BankLab version အလိုက် ရွေးပါ။

အဆင့်တိုင်းမှာ **နမူနာဖိုင်ကိုဖတ် → ဒီ feature ဘာကြောင့်လိုလဲ ရှင်းပြ → ကိုယ်တိုင်ထည့် → အလုပ်လုပ်ကြောင်း စစ်** ဆိုတဲ့ အစဉ်နဲ့ သွားပါမယ်။ တစ်ခါတည်း setup အကုန်ထည့်ရန် မလိုပါ။ အောက်ကအဆင့်တွေကို သက်ဆိုင်ရာအပတ်ရဲ့ မူလ lab အချိန်ထဲမှာ လုပ်ပါ။

| ဘယ်အချိန် | ဘာကြောင့် ထည့်မလဲ | BankLab မှာ ကိုယ်တိုင်လုပ်ရန် | ပြီးမြောက်မှုစံ |
|---|---|---|---|
| **ပတ် ၁ · API run** | App host၊ HTTP port နဲ့ Development profile ဘယ်ကလာလဲ သိဖို့ | Api ရဲ့ `Program.cs` နဲ့ `Properties/launchSettings.json` ကိုဖတ်ပါ။ `dotnet build src/BankLab.slnx` ပြီး `dotnet run --project src/BankLab.Api --launch-profile https` သုံးပါ။ Visual Studio မှာ Api ကို startup project ရွေးပြီး https profile နဲ့လည်း စမ်းပါ။ | Console ထဲပြတဲ့ URL မှာ `/weatherforecast` ကို ခေါ်ပြီး HTTP 200 ရရမယ်။ လက်ရှိ https profile URL က `https://localhost:7087` ဖြစ်တယ်။ |
| **ပတ် ၁ · OpenAPI နှင့် Scalar** | Endpoint စာရင်းနဲ့ request/response နမူနာကို browser မှာ စမ်းဖို့ | `AddOpenApi()` က document generator register လုပ်ပေးတယ်။ `MapOpenApi()` က JSON route ဖွင့်ပေးတယ်။ Api မှာ `Scalar.AspNetCore` package ထည့်ပြီး Development block ထဲ `MapScalarApiReference("/docs/scalar")` ချိတ်ပါ။ | `/openapi/v1.json` ကို အရင်ဖွင့်ပါ။ ပြီးရင် `/docs/scalar` ကနေ sample endpoint ကို ခေါ်လို့ရရမယ်။ |
| **ပတ် ၃ · Model နဲ့ folder mapping** | ERD အရ ဘယ် class နဲ့ mapping ကို ဘယ် project မှာ ရေးမလဲ သိဖို့ | Account နဲ့ ledger entities ကို Domain ထဲ၊ journal posting use case ကို Application ထဲ၊ SQL Server mappings ကို `Infrastructure/Persistence/Configurations` ထဲ ထားမယ့်ပုံစံ ဆွဲပါ။ | Deposit ၁,၀၀၀.၀၀ အတွက် header ၁ ခု၊ debit/credit lines ၂ ကြောင်းနဲ့ table keys ကို ရှင်းပြနိုင်ရမယ်။ |
| **ပတ် ၄ · DbContext နှင့် database connection** | Domain model ကို SQL Server table တွေနဲ့ ချိတ်ပြီး persisted data ဖတ်/ရေးဖို့ | `Infrastructure/Persistence/BankLabDbContext.cs` နဲ့ entity configurations ရေးပါ။ Infrastructure ရဲ့ `AddInfrastructureServices(configuration)` ထဲ `AddDbContext` / `UseSqlServer` ချိတ်ပြီး Api ရဲ့ `Program.cs` က ခေါ်ပါ။ Api user secrets မှာ `ConnectionStrings:DefaultConnection` သတ်မှတ်ပါ။ | API startup project က connection string ဖတ်နိုင်ပြီး local BankLab database ဆီ ချိတ်နိုင်ရမယ်။ စမ်းသပ်တဲ့ account တစ်ခုကို EF Core နဲ့ သိမ်းပြီး ပြန်ဖတ်ပါ။ |
| **ပတ် ၄ · EF Core migration** | Model ပြောင်းလဲမှုကို ပြန်စစ်လို့ရတဲ့ schema history နဲ့ စီမံဖို့ | `dotnet ef` 11.x ကို စစ်ပါ။ Infrastructure ကို migration target၊ Api ကို startup project ရွေးပါ။ Api startup မှာ EF tools တောင်းတဲ့ `Microsoft.EntityFrameworkCore.Design` 11.x reference ကို migration lab အတွက် ထည့်ပါ။ Migration ကို အရင်ကြည့်ပြီးမှ local database ကို update လုပ်ပါ။ | Migration နဲ့ snapshot ထွက်ပြီး အလွတ် database နဲ့ upgrade path နှစ်မျိုးလုံး စမ်းနိုင်ရမယ်။ |
| **ပတ် ၄–၅ · DI နှင့် use cases** | Controller က SQL Server implementation ကို အသေးစိတ် မသိဘဲ use case ခေါ်လို့ရဖို့ | လိုလာတဲ့ persistence interface ကို Application မှာ သတ်မှတ်ပြီး Infrastructure မှာ EF implementation ချိတ်ပါ။ `AddApplicationServices()` ကို use case registration လိုချိန်မှ ထည့်ပါ။ ပတ် ၅ မှာ command/query ကို controller က ခေါ်ပုံ ရေးပြီး MediatR သို့ FluentValidation သုံးမယ်ဆို သူတို့ ဖြေရှင်းပေးမယ့်အလုပ်ကို မြင်ပြီးမှ ထည့်ပါ။ | Api → use case → database လမ်းကြောင်းကို ရှင်းပြနိုင်ရမယ်။ Valid transfer နဲ့ rejected transfer response ကို စမ်းပါ။ |
| **ပတ် ၁၂–၁၆ · လုပ်ငန်း feature အသီးသီး** | Identity၊ messaging၊ cache နဲ့ deployment ကို သူတို့လိုလာတဲ့ flow မှာ နားလည်ဖို့ | ပတ် ၁၂ မှာ Identity/authorization နဲ့ ownership၊ ပတ် ၁၃ မှာ worker/broker configuration၊ ပတ် ၁၄ မှာ cache၊ ပတ် ၁၆ မှာ environment secrets နဲ့ release migration ကို သက်ဆိုင်ရာ module မှာ ထည့်ပါ။ | အပတ်တိုင်း မူလ acceptance criteria နဲ့ သက်ဆိုင်ရာ feature ကို စစ်ပါ။ |

### Inventory ဖိုင်တွေထဲမှာ ကြည့်ရမည့်နေရာ

- **Run နှင့် docs route** ကို `Api/Properties/launchSettings.json` နဲ့ `Api/Program.cs` မှာ ကြည့်ပါ။ Inventory မှာ `MapOpenApi()` နဲ့ Scalar route ကို Development မှာ map လုပ်ထားတယ်။ Inventory က OpenAPI 3.0 ကို သတ်မှတ်ထားပြီး BankLab ရဲ့ ASP.NET Core 11 generator က OpenAPI 3.2 ကို default သုံးတယ်။ BankLab မှာ Scalar က JSON ကို ဖတ်နိုင်ကြောင်း အရင်စမ်းပါ။ [Inventory run instructions](https://github.com/Sitt-Paing/InventoryManagementSystem#readme) · [Scalar ASP.NET Core integration](https://scalar.com/products/api-references/integrations/aspnetcore/integration) · [ASP.NET Core 11 release overview](https://devblogs.microsoft.com/dotnet/announcing-dotnet-11/)
- **Database wiring** ကို Inventory ရဲ့ `Infrastructure/DependencyInjection.cs` မှာ ကြည့်ပါ။ Inventory မှာ inventory data နဲ့ Identity အတွက် DbContext နှစ်ခု ရှိတယ်။ BankLab မှာ CustomerId FK ကို context တစ်ခုထဲ map လုပ်နိုင်အောင် `BankLabDbContext` တစ်ခုနဲ့ စမယ်။ [Inventory Infrastructure registration](https://github.com/Sitt-Paing/InventoryManagementSystem/blob/b1e9f659d0a846fb878505ada0d5ba5225aa7040/src/InventoryManagementSystem.Infrastructure/DependencyInjection.cs) · [BankLab database design](Database-Design.md) · [EF Core DbContext configuration](https://learn.microsoft.com/en-us/ef/core/dbcontext-configuration/)
- **Dependencies** မှာ `.csproj` ထဲက `ProjectReference` က BankLab project အချင်းချင်း code သုံးလို့ရအောင် ချိတ်တယ်။ `PackageReference` က Scalar နဲ့ EF Core လို NuGet library ထည့်တယ်။ `Program.cs` နဲ့ `DependencyInjection.cs` က run ချိန် ဘယ် implementation သုံးမလဲ register လုပ်တယ်။ BankLab Infrastructure ထဲမှာ EF Core/SQL Server/Identity packages ရှိပြီးသားမို့ လိုတဲ့ registration နဲ့ model ကို lab အဆင့်ရောက်မှ ဖြည့်ပါ။ [ASP.NET Core dependency injection](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection)

### ပတ် ၄ မှာ ကိုယ်တိုင်စမ်းမည့် commands

Windows Authentication သုံးတဲ့ local SQL Server နမူနာပါ။ ကိုယ့်စက်က SQL Server အမည်နဲ့ ကိုက်အောင် `Server=localhost` ကို ပြင်ပါ။ User secrets ကို Api project မှာ သိမ်းပြီး Development ကို ရွေးပါ။ [ASP.NET Core user secrets](https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets)

```powershell
dotnet user-secrets init --project src/BankLab.Api
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=localhost;Database=BankLab;Trusted_Connection=True;TrustServerCertificate=True" --project src/BankLab.Api
```

DbContext နဲ့ registration ရေးပြီးမှ BankLab root ကနေ အောက်ကအတိုင်း စမ်းပါ။ `--project` က migration ထုတ်မယ့် project၊ `--startup-project` က configuration နဲ့ DI ဖတ်မယ့် host ပါ။ EF tooling က startup host ကနေ context မရတဲ့အခါ design-time factory ကို လေ့လာပါ။ Factory သုံးရင် runtime နဲ့ provider/model options တူကြောင်း စစ်ပါ။ [EF Core CLI](https://learn.microsoft.com/en-us/ef/core/cli/dotnet) · [Design-time DbContext creation](https://learn.microsoft.com/en-us/ef/core/cli/dbcontext-creation)

```powershell
dotnet ef dbcontext info --project src/BankLab.Infrastructure --startup-project src/BankLab.Api --context BankLabDbContext -- --environment Development
dotnet ef migrations add InitialBankingSchema --project src/BankLab.Infrastructure --startup-project src/BankLab.Api --context BankLabDbContext --output-dir Persistence/Migrations -- --environment Development
dotnet ef database update --project src/BankLab.Infrastructure --startup-project src/BankLab.Api --context BankLabDbContext -- --environment Development
```

Local HTTPS လက်မှတ်ကို browser က မယုံကြည်သေးရင် ပတ် ၁ မှာ Windows အတွက် `dotnet dev-certs https --trust` နဲ့ ပြင်ပြီး https profile ကို ပြန် run ပါ။ Connection string ထဲက `TrustServerCertificate=True` က အထက်က local SQL Server နမူနာအတွက်ပါ။ Staging မှာ SQL Server ရဲ့ ယုံကြည်ရတဲ့ certificate နဲ့ environment config သုံးပါ။ [ASP.NET Core HTTPS development certificate](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-dev-certs) · [SQL Server connection encryption](https://learn.microsoft.com/en-us/sql/connect/ado-net/encryption-and-certificate-validation)

## Capstone ပုံစံ

- **Backend** ASP.NET Core Web API modular monolith။ Customers/Accounts၊ Ledger၊ Transfers၊ Payments၊ Compliance၊ Reconciliation ဆိုပြီး လုပ်ငန်းတာဝန်ခွဲပါ။ Worker က outbox နဲ့ statement import ကို ကိုင်ပါ။
- **Data** SQL Server မှာ journal headers/lines၊ GL accounts၊ customer subaccounts၊ balance projections၊ transfers၊ payment attempts၊ idempotency records၊ holds၊ outbox/inbox၊ reconciliation cases နဲ့ audit events တည်ဆောက်ပါ။
- **Frontend** Angular Reactive Forms နဲ့ PrimeNG သုံးပြီး customer အတွက် balance/transfer/statement၊ operator အတွက် KYC review/reconciliation၊ auditor အတွက် read-only journal views လုပ်ပါ။
- **ငွေကြေးစည်းကမ်း** Lab currency တစ်မျိုးကို decimal scale 2 သတ်မှတ်ပါ။ C# မှာ decimal၊ SQL Server မှာ decimal(19,2)၊ HTTP မှာ decimal string သုံးပါ။ ပိုတဲ့ decimal places၊ zero/negative amount နဲ့ currency mismatch ကို API မှာ reject ပါ။ UI မှာ authoritative balance arithmetic ကို JavaScript Number နဲ့ မလုပ်ပါနှင့်။
- **စာရင်းစည်းကမ်း** Posted journal မှာ line အနည်းဆုံး ၂ ကြောင်း၊ positive amount၊ debit/credit နှစ်ဖက်ညီရမယ်။ Posting service သည် transaction အတွင်း line အားလုံးစစ်ပြီးမှ commit လုပ်မယ်။ Foreign key၊ unique index နဲ့ row check constraints ထပ်တပ်ပါ။ Journal line စုစုပေါင်းညီမှုကို row-level CHECK တစ်ခုတည်းဖြင့် မဖော်ပြနိုင်ပါ။
- **လက်ကျန်** Posted journal က ledger balance ပြန်တည်ဆောက်ရာ အခြေခံဖြစ်တယ်။ Lab မှာ available balance = ledger balance − active holds၊ overdraft = 0 ဖြစ်တယ်။ ငွေသုံးခွင့်ဆုံးဖြတ်ချက်ကို transaction ထဲက database state နဲ့ စစ်ပါ။
- **အချိန်နှင့် ဆက်စပ်မှတ်တမ်း** UTC timestamps၊ သီးခြား business date နှင့် သတ်မှတ်ထားသော cut-off timezone သုံးပါ။ Transaction ID၊ journal ID၊ external reference နဲ့ correlation ID ကို သီးခြားသိမ်းပါ။

### ဘဏ်ဘက်မှ နမူနာ Journal

| လုပ်ငန်း | Debit | Credit | ပမာဏ |
|---|---|---|---:|
| A အကောင့်သို့ ငွေသားသွင်း | Cash asset | Deposits liability / A | 1,000.00 |
| A မှ B သို့ ဘဏ်တွင်းလွှဲ | Deposits liability / A | Deposits liability / B | 250.00 |
| B မှ ငွေသားထုတ် | Deposits liability / B | Cash asset | 50.00 |
| A အကောင့်မှ ဝန်ဆောင်ခဖြတ် | Deposits liability / A | Fee income | 10.00 |

မျှော်မှန်းရလဒ်မှာ A = 740.00၊ B = 200.00၊ Deposit GL control = 940.00 credit၊ Cash = 950.00 debit၊ Fee income = 10.00 credit ဖြစ်တယ်။ Trial balance debit နဲ့ credit တစ်ဖက်စီ 950.00 ဖြစ်ရမယ်။ GL control report ကို subaccount lines မှ GL account အလိုက် roll up လုပ်ပါ။ Subaccount line တစ်ကြောင်းအတွက် control account ကို ငွေစာရင်းထဲ ဒုတိယအကြိမ် မသွင်းပါနှင့်။

## အပတ်စဉ် သင်ခန်းစာနှင့် Lab

### ပတ် 01 — ဘဏ်လုပ်ငန်းအခြေခံ

- **ရည်မှန်းချက်** Customer၊ teller၊ operations၊ compliance နဲ့ finance တို့ရဲ့ အလုပ်တာဝန်နဲ့ ငွေစီးကြောင်းကို ရှင်းပြနိုင်မယ်။
- **သီအိုရီ** Retail deposits၊ lending နဲ့ fee income၊ bank balance sheet၊ liquidity၊ customer/account/product ခွဲခြားပုံ၊ account lifecycle။
- **လုပ်ငန်းစဉ်** Customer ဖွင့် → KYC ဆုံးဖြတ် → account activate → deposit → withdrawal → statement။
- **Lab** Actors နဲ့ system context ဆွဲပါ။ Active/frozen/closed state table နဲ့ deposit/withdrawal allowed actions သတ်မှတ်ပါ။ API/SQL Server/UI ကို local မှာ smoke test လုပ်ပါ။
- **ပေးပို့ရန်** Glossary၊ context diagram၊ account lifecycle၊ local setup README။
- **လက်ခံစံ** Customer ၂ ဦး၊ account ၃ ခုပါ dataset ကို ရှင်းပြနိုင်ရမယ်။ Deposit က bank liability တိုးကြောင်းနဲ့ frozen account မှ outgoing transfer ကို ဘယ်သူပိတ်သလဲ ပြနိုင်ရမယ်။
- **ဖတ်ရန်** [OpenStax Money and Banking](https://openstax.org/books/principles-economics-3e/pages/27-introduction-to-money-and-banking)

### ပတ် 02 — Double-entry accounting

- **ရည်မှန်းချက်** Bank perspective နဲ့ debit/credit ကို ရွေးပြီး journal မှ trial balance ထုတ်နိုင်မယ်။
- **သီအိုရီ** Accounting equation၊ normal balance၊ chart of accounts၊ journal/T-account၊ posting၊ reversal။
- **လုပ်ငန်းစဉ်** Cash deposit၊ internal transfer၊ withdrawal၊ fee၊ မှားသွင်းသော fee ကို full reversal ဖြင့် ပြန်ပြင်ခြင်း။
- **Lab** အပေါ်က fixture ကို လက်နဲ့တွက်ပါ။ C# console program နဲ့ line validation၊ T-account totals၊ trial balance ထုတ်ပါ။ Reversal ကို original journal ID ချိတ်ပါ။
- **ပေးပို့ရန်** Journal worksheet၊ posting examples၊ accounting tests။
- **လက်ခံစံ** A/B နှင့် trial balance က fixture အတိုင်းထွက်ရမယ်။ Unbalanced entry ပယ်ရမယ်။ Fee reversal ပြီး fee income = 0.00၊ A = 750.00 ဖြစ်ရမယ်။
- **ဖတ်ရန်** [OpenStax Accounting Cycle](https://openstax.org/books/principles-financial-accounting/pages/3-3-define-and-describe-the-initial-steps-in-the-accounting-cycle) · [Journal Entries and T-Accounts](https://openstax.org/books/principles-financial-accounting/pages/3-5-use-journal-entries-to-record-transactions-and-post-to-t-accounts)

### ပတ် 03 — GL၊ subledger နှင့် ledger architecture

- **ရည်မှန်းချက်** Customer statement နဲ့ GL control balance ကို တူညီတဲ့ posted facts ကနေ ပြန်ထုတ်နိုင်မယ်။
- **သီအိုရီ** GL နှင့် customer subledger၊ posting rules၊ append-only journal၊ posting time/effective date၊ read projection၊ hold capture/release။
- **လုပ်ငန်းစဉ်** Deposit instruction → validate → post → customer statement → daily GL roll-up။
- **Lab** ERD၊ chart of accounts နဲ့ event-to-journal mapping ဆွဲပါ။ Deposit၊ withdrawal၊ fee၊ transfer၊ reversal အတွက် posting rules နဲ့ hold state diagram ရေးပါ။ Projection ဖျက်ပြီး journal မှ replay လုပ်မယ့် query/algorithm ရေးပါ။
- **ပေးပို့ရန်** ERD၊ posting matrix၊ ledger design decision မှတ်တမ်း။
- **လက်ခံစံ** As-of business date တစ်ခုအတွက် customer subledger sum = deposit control balance ဖြစ်ရမယ်။ Active hold က available balance ကိုသာ လျှော့ပြီး release က available balance ပြန်တိုးရမယ်။
- **ဖတ်ရန်** [CGAP Accounting Training](https://www.cgap.org/sites/default/files/CGAP-Training-Accounting-Principles-for-Microfinance-Institutions-Course-2009_0.pdf)

### ပတ် 04 — EF Core code-first နှင့် SQL Server

- **ရည်မှန်းချက်** Posting ကို SQL Server transaction အဖြစ် တည်ဆောက်ပြီး schema ပြောင်းလဲမှုကို migrations ဖြင့် စီမံနိုင်မယ်။
- **သီအိုရီ** DbContext၊ entity mapping၊ decimal precision၊ unique index၊ FK နှင့် constraints၊ atomic commit/rollback။
- **လုပ်ငန်းစဉ်** Cash deposit → journal header/lines နှင့် balance projection → commit → statement query။
- **Lab** Initial migration နဲ့ seed fixture ထည့်ပါ။ ဒုတိယ migration ဖြင့် statement query အတွက် index ထည့်ပါ။ Empty DB နှင့် ပထမ migration အဆင့်မှာရှိပြီးသား DB နှစ်ခုလုံး upgrade လုပ်ပါ။ Commit မတိုင်ခင် exception ထည့်စမ်းပါ။
- **ပေးပို့ရန်** Entities၊ migrations၊ seed command၊ SQL Server integration test နဲ့ migration SQL။
- **လက်ခံစံ** DB နှစ်ခု schema တူရမယ်၊ upgrade ပြီး fixture ကျန်ရမယ်။ Failure ဖြစ်ရင် journal header၊ lines နဲ့ projection အားလုံး rollback ဖြစ်ရမယ်။
- **ဖတ်ရန်** [EF Core Migrations](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/applying) · [EF Core Transactions](https://learn.microsoft.com/en-us/ef/core/saving/transactions)

### ပတ် 05 — Internal transfer API

- **ရည်မှန်းချက်** Same-bank transfer ကို validation မှ receipt အထိ တစ်ကြိမ်တည်း တိကျစွာ post လုပ်နိုင်မယ်။
- **သီအိုရီ** Command/query၊ DTO နှင့် domain validation၊ Problem Details၊ account ownership၊ available balance၊ atomic posting။
- **လုပ်ငန်းစဉ်** Source account အတည်ပြု → destination/amount စစ် → transfer post → receipt → နှစ်ဖက် statement။
- **Lab** POST /transfers၊ GET /transfers/{id}၊ paged statement endpoint ဆောက်ပါ။ Closed/frozen account၊ self-transfer၊ insufficient funds နှင့် invalid amount အတွက် domain tests ရေးပါ။
- **ပေးပို့ရန်** API contract၊ request examples၊ transfer service နဲ့ tests။
- **လက်ခံစံ** 1,000.00 မှ 250.00 လွှဲလျှင် 750.00/250.00 ဖြစ်ရမယ်။ Rejected request မှ journal/projection ပြောင်းလဲမှု 0 ဖြစ်ရမယ်။ Receipt က journal ID ဆီ trace လုပ်နိုင်ရမယ်။
- **ဖတ်ရန်** [Microsoft ASP.NET Core Web APIs](https://learn.microsoft.com/en-us/aspnet/core/web-api/) · [RFC 9457 Problem Details](https://www.rfc-editor.org/rfc/rfc9457)

### ပတ် 06 — Idempotency နှင့် retry

- **ရည်မှန်းချက်** Request ပြန်ပို့လာရင် အရင်ရလဒ်ကို ပြန်ပေးပြီး ငွေထပ်မရွှေ့စေရ။
- **သီအိုရီ** Client operation key၊ principal/operation scope၊ normalized payload fingerprint၊ unique constraint၊ commit အောင်ပြီး response မရသောအခြေအနေ။
- **လုပ်ငန်းစဉ်** Submit → commit → response ပျောက် → key တူတူဖြင့် retry → မူလ receipt ရ။
- **Lab** Key scope ကို principal + operation + key ဖြင့် unique လုပ်ပါ။ Transfer/journal/result record ကို transaction တစ်ခုအတွင်း commit လုပ်ပါ။ Concurrent duplicate က unique conflict ရပါက rollback ပြီး fresh context မှ committed record ဖတ်ပါ။ Replay ကာလကို API contract မှာ ရေးပါ။
- **ပေးပို့ရန်** Idempotency contract နဲ့ retry/duplicate test report။
- **လက်ခံစံ** Same key + same command ဖြင့် sequential/parallel replay တို့က journal တစ်ခုနဲ့ receipt ID တစ်ခုသာ ရရမယ်။ Same key + different amount → 409။ Response ပျောက်သည့်စမ်းသပ်မှုမှာ original receipt ပြန်ရရမယ်။
- **ဖတ်ရန်** [RFC 9110 Idempotent Methods](https://www.rfc-editor.org/rfc/rfc9110.html#name-idempotent-methods) · [Stripe API Idempotent Requests](https://docs.stripe.com/api/idempotent_requests)

### ပတ် 07 — Concurrency နှင့် transaction isolation

- **ရည်မှန်းချက်** Account တစ်ခုမှ ပြိုင်တူငွေထွက်နေချိန် overdraft မဖြစ်အောင် SQL Server ဖြင့် ထိန်းနိုင်မယ်။
- **သီအိုရီ** Lost update၊ locking၊ isolation levels၊ rowversion၊ deadlock၊ optimistic retries။ Snapshot ဖတ်ချက်တစ်ခုတည်းနဲ့ spend rule ကို မဆုံးဖြတ်ပါနှင့်။
- **လုပ်ငန်းစဉ်** 100.00 ရှိသော A မှ 80.00 စီကို B နှင့် C သို့ သီးခြား request key ဖြင့် တစ်ချိန်တည်း လွှဲ။
- **Lab** Balance row မှာ rowversion သုံးပါ။ Conflict ဖြစ်ရင် အကန့်အသတ်ရှိသော retry ဖြင့် transaction အစမှ balance နဲ့ holds ပြန်ဖတ်ပါ။ Hold အပြောင်းအလဲတွေကိုလည်း version စစ်မှုတူတူမှာ ပါစေ။ ပြိုင်တူ test ကို သီးခြား DbContext/connection နှစ်ခုဖြင့် barrier သုံးပြီး run ပါ။
- **ပေးပို့ရန်** SQL Server race test၊ isolation ရွေးချယ်မှုမှတ်တမ်း၊ retry policy။
- **လက်ခံစံ** 80.00 transfer တစ်ခုသာ post၊ A = 20.00၊ ledger balanced။ Bidirectional transfer စမ်းသပ်ပြီး deadlock ဖြစ်လာပါက transaction လုံးဝ rollback/retry ဖြစ်ကြောင်း စစ်ပါ။
- **ဖတ်ရန်** [EF Core Concurrency](https://learn.microsoft.com/en-us/ef/core/modeling/concurrency) · [SQL Server Locking and Row Versioning](https://learn.microsoft.com/en-us/sql/relational-databases/sql-server-transaction-locking-and-row-versioning-guide)

### ပတ် 08 — Angular နှင့် PrimeNG UI

- **ရည်မှန်းချက်** Customer ကို review၊ submit၊ receipt၊ statement အဆင့်တစ်ခုချင်းစီမှာ မှန်ကန်သောအခြေအနေ ပြနိုင်မယ်။
- **သီအိုရီ** Typed Reactive Forms၊ HTTP error mapping၊ server pagination၊ accessibility၊ loading/empty/error states။
- **လုပ်ငန်းစဉ်** Account ရွေး → transfer form → review → submit → receipt → statement refresh။
- **Lab** PrimeNG Table ဖြင့် statement၊ form validation၊ review dialog နှင့် status message ဆောက်ပါ။ Submit လုပ်နေစဉ် ခလုတ်ပိတ်ပြီး timeout မှာ command တူလျှင် မူလ key နဲ့ retry လုပ်ပါ။ Input ပြောင်းပြီး command အသစ်ဖြစ်လျှင် key အသစ်ထုတ်ပါ။
- **ပေးပို့ရန်** Customer UI demo၊ keyboard walkthrough၊ end-to-end test။
- **လက်ခံစံ** Keyboard ဖြင့် flow ပြီးစီးရမယ်။ Timeout နောက် retry က receipt တစ်ခုတည်း ပြရမယ်။ Insufficient funds error ကို field/general message အဖြစ်ဖတ်နိုင်ပြီး receipt view မှ transaction ID မြင်ရမယ်။
- **ဖတ်ရန်** [Angular Reactive Forms](https://angular.dev/guide/forms/reactive-forms) · [PrimeNG Table](https://primeng.dev/table)

### ပတ် 09 — External payments နှင့် settlement

- **ရည်မှန်းချက်** Payment instruction၊ clearing၊ settlement နဲ့ return ကို အဆင့်လိုက် trace လုပ်နိုင်မယ်။
- **သီအိုရီ** On-us/off-us၊ settlement finality၊ provider reference၊ pending/unknown၊ holds၊ clearing payable။
- **လုပ်ငန်းစဉ်** Payment request → funds hold → mock provider submit → accepted → settlement confirmation။ Rejected ဆို hold release၊ timeout ဆို status lookup၊ settled ပြီး return ဝင်လျှင် linked compensating journal။
- **Lab** Mock provider နှင့် state machine ဆောက်ပါ။ Hold ကို accepted အဆင့်မှာ capture လုပ်ပြီး Dr customer deposit liability / Cr clearing payable post ပါ။ Settlement မှာ Dr clearing payable / Cr settlement cash post ပါ။ Rejection၊ duplicate callback နဲ့ out-of-order callback fixtures ထည့်ပါ။
- **ပေးပို့ရန်** State diagram၊ provider contract၊ posting matrix နှင့် payment demo။
- **လက်ခံစံ** 80.00 hold က available 80.00 လျော့စေတယ်။ Capture က hold ကို ဖယ်ပြီး posted balance 80.00 လျော့စေတယ်။ Settlement က clearing payable ကို zero ပြန်ရောက်စေတယ်။ Timeout မှာ provider reference ဖြင့် အရင်အခြေအနေ ရှာပြီး duplicate debit မဖြစ်ရ။
- **ဖတ်ရန်** [BIS CPMI Glossary](https://www.bis.org/committees/cpmi/glossary) · [ISO 20022 Message Definitions](https://www.iso20022.org/iso-20022-message-definitions)

### ပတ် 10 — Reconciliation နှင့် end-of-day

- **ရည်မှန်းချက်** Internal payments၊ external statement နှင့် GL ကို ဖြတ်ရက်တစ်ခုအလိုက် တိုက်ပြီး ကွာဟချက်ကို စီမံနိုင်မယ်။
- **သီအိုရီ** Control totals၊ cut-off၊ exact match၊ missing/duplicate/amount mismatch/timing break၊ clearing နှင့် suspense accounts။
- **လုပ်ငန်းစဉ်** External statement import → normalize → reference/currency/amount စစ် → exact match → exception queue → maker-checker resolution → closure evidence။
- **Lab** Mock CSV import၊ raw file hash၊ uniqueness per provider/batch/line၊ deterministic match rules နဲ့ exception UI လုပ်ပါ။ Ambiguous match ကို manual review ပို့ပါ။ Correction အတည်ပြုရင် linked journal ဖြင့် post ပါ။
- **ပေးပို့ရန်** CSV fixtures၊ matching rules၊ daily totals report၊ operator demo။
- **လက်ခံစံ** Fixture ၆ case (exact၊ external-only၊ internal-only၊ amount mismatch၊ duplicate၊ cutoff timing) ကို expected status အတိုင်း ပြရမယ်။ File တူ replay လျှင် row/case မတိုးရ။ Opening + movements = closing နှင့် GL/subledger difference ကို report မှာ စစ်နိုင်ရမယ်။
- **ဖတ်ရန်** [CGAP Accounting Training](https://www.cgap.org/sites/default/files/CGAP-Training-Accounting-Principles-for-Microfinance-Institutions-Course-2009_0.pdf) · [BIS CPMI Glossary](https://www.bis.org/committees/cpmi/glossary)

### ပတ် 11 — KYC/AML နှင့် compliance workflow

- **ရည်မှန်းချက်** Onboarding၊ ongoing monitoring နှင့် case review အတွက် auditable workflow တစ်ခု တည်ဆောက်နိုင်မယ်။
- **သီအိုရီ** Customer due diligence၊ beneficial owner၊ risk-based approach၊ screening၊ monitoring၊ escalation နှင့် record keeping။ FATF Recommendations 1၊ 10၊ 11၊ 20 တို့ကို သက်ဆိုင်ရာ jurisdiction စည်းမျဉ်းနှင့် ခွဲဖတ်ပါ။
- **လုပ်ငန်းစဉ်** Application → identity review → screening → accept/reject/escalate → account eligibility → periodic review။ Monitoring alert → analyst review → supervisor decision → audit။
- **Lab** Synthetic risk fixtures၊ mock screening service နဲ့ case queue ဆောက်ပါ။ Reviewer decision၊ reason၊ actor၊ timestamp ထည့်ပါ။ Alert ထုတ်ရန် lab rule တစ်ခုသာ သတ်မှတ်ပြီး fixture များဖြင့် စမ်းပါ။
- **ပေးပို့ရန်** State chart၊ synthetic dataset၊ review screen နဲ့ audit evidence။
- **လက်ခံစံ** Approved customer သာ account activate လုပ်နိုင်ရမယ်။ Pending screening ကို operator မကျော်နိုင်ရ။ Escalated case မှာ history အပြည့် ပြန်ရှာနိုင်ပြီး sensitive fields ကို သတ်မှတ် role သာ မြင်ရမယ်။
- **ဖတ်ရန်** [FATF Recommendations](https://www.fatf-gafi.org/en/publications/Fatfrecommendations/Fatf-recommendations.html)

### ပတ် 12 — Application security နှင့် audit

- **ရည်မှန်းချက်** Account ownership၊ role segregation နဲ့ auditability ကို API တစ်ဆင့်ချင်းမှာ စစ်နိုင်မယ်။
- **သီအိုရီ** Authentication နှင့် authorization၊ OIDC အခြေခံ၊ least privilege၊ policy/resource authorization၊ cookie သုံးလျှင် CSRF protection၊ TLS၊ secret handling၊ PII masking။
- **လုပ်ငန်းစဉ်** Sign in → account access → transfer → audit trail။ Maker တင်သော reconciliation correction ကို checker သီးခြားတစ်ဦး approve လုပ်။
- **Lab** Framework authentication နဲ့ role/resource policies တပ်ပါ။ Customer A မှ B ရဲ့ account endpoint ကို ခေါ်ခြင်း၊ auditor မှ write ခေါ်ခြင်း၊ maker မှ ကိုယ်ပိုင် case approve ခေါ်ခြင်းတို့ကို authorization integration tests ဖြင့် စစ်ပါ။ Threat model နဲ့ ASVS control mapping ရေးပါ။
- **ပေးပို့ရန်** Permission matrix၊ threat model၊ audit sample၊ ASVS verification results။
- **လက်ခံစံ** Anonymous call → 401၊ role မလုံလောက် → 403၊ cross-account request ကို API contract အတိုင်း deny လုပ်ရမယ်။ Denied actions မှာ business writes 0။ Logs ထဲ credentials၊ tokens နဲ့ raw KYC identifiers မပါရ။
- **ဖတ်ရန်** [OWASP ASVS](https://asvs.owasp.org/) · [ASP.NET Core Resource-Based Authorization](https://learn.microsoft.com/en-us/aspnet/core/security/authorization/resourcebased)

#### BankLab login၊ browser session နှင့် audit အတွက် design ဆုံးဖြတ်ချက်

InventoryManagementSystem ကဲ့သို့ Api က authentication middleware နှင့် browser protections ကို ချိတ်ပြီး Infrastructure က identity integration၊ Application က permission နှင့် ownership စစ်ဆေးမှုကို ကိုင်မယ်။ အောက်ပါအဆင့်တွေကို ကိုယ်တိုင်ထည့်ပြီး flow ပြည့်မှ စုပေါင်းစမ်းပါ။

1. **Login** — သီးခြား OpenID Connect identity provider ကို ရွေးပါ။ Teller login အတွက် MFA၊ web client အတွက် authorization code + PKCE သုံးပါ။ API က issuer၊ audience၊ signature၊ expiry တို့ကို စစ်ပြီး provider ရဲ့ public keys နဲ့ signing-key rotation ကို လက်ခံနိုင်ရမယ်။ Inventory ရဲ့ shared-secret token issuer နဲ့ fallback key ကို BankLab production design ထဲ မယူပါ။ [Microsoft JWT bearer guidance](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/configure-jwt-bearer-authentication)
2. **Browser** — Angular နှင့် same-origin backend-for-frontend (BFF) သုံးမယ်။ Access/refresh tokens ကို server ဘက်မှာ ထိန်းပြီး browser ကို Secure၊ HttpOnly session cookie ပေးမယ်။ State-changing requests မှာ Inventory ရဲ့ X-XSRF-TOKEN header ပုံစံကို ဆက်သုံးပြီး server မှာ antiforgery token pair စစ်ပါ။ Logout မှာ session ပိတ်၍ idle/absolute expiry ကို policy နဲ့သတ်မှတ်ပါ။ [Microsoft antiforgery guidance](https://learn.microsoft.com/en-us/aspnet/core/security/anti-request-forgery)
3. **Authorization နှင့် audit** — Customer ပိုင်ဆိုင်မှု၊ teller permissions၊ maker/checker ခွဲခြားမှုကို server ဘက်မှာ စစ်ပါ။ Audit event မှာ immutable actor ID (issuer + subject)၊ လုပ်ဆောင်ချိန် username၊ UTC time၊ action၊ outcome နှင့် correlation ID ထည့်ပါ။ Customer row ရဲ့ CreatedBy အပြင် ပြင်ဆင်ခွင့်ကန့်သတ်ထားသော append-only audit history ကို စီစဉ်ပါ။
4. **Secrets နှင့် verification** — dotnet user-secrets ကို local development အတွက် သုံးပြီး deployment မှာ managed secret store သုံးပါ။ Permission မရှိသော teller၊ အခြား customer account၊ CSRF token ပျောက်မှု၊ expired session၊ self-approval တို့ကို ပယ်ရမယ်။ အောင်မြင်သောလုပ်ဆောင်မှုကို actor ID နဲ့ audit ထိ ချိတ်ပြနိုင်ရမယ်။ Partner/open-banking API ထည့်လာရင် သီးခြား FAPI profile နှင့် ကိုက်ညီမှုကို လေ့လာပါ။ [OpenID Foundation FAPI 2.0](https://openid.net/specs/fapi-security-profile-2_0-final.html)

### ပတ် 13 — Messaging၊ transactional outbox နှင့် inbox

- **ရည်မှန်းချက်** Broker ပျက်ခြင်း၊ message ပြန်ဝင်ခြင်းတွေကြားမှာ business state ကို တည်ငြိမ်စွာ ထိန်းနိုင်မယ်။
- **သီအိုရီ** At-least-once delivery၊ publish confirms၊ consumer acknowledgements၊ retries၊ dead-letter queue၊ event schema/versioning။
- **လုပ်ငန်းစဉ်** Journal + outbox commit → worker publish → consumer inbox + side effect commit → ACK။ Broker ပြန်တက်ရင် pending outbox ဆက်ပို့။
- **Lab** .NET Worker နဲ့ RabbitMQ တည်ဆောက်ပါ။ Publish success ပြီး outbox status update မတိုင်ခင် worker ကို stop လုပ်ပါ။ Consumer က event ID unique inbox နှင့် side effect ကို transaction တစ်ခုအတွင်း ရေးပါ။ Retry limit နောက် poison message ကို dead-letter ရွှေ့ပါ။
- **ပေးပို့ရန်** Event contract၊ delivery diagram၊ restart/replay evidence။
- **လက်ခံစံ** Broker down ချိန် commit လုပ်ထားသော event ပျောက်မှု 0။ Event တူ ၅ ကြိမ်ရောက်လျှင် downstream DB effect ၁ ကြိမ်။ Dead-letter message ကို correlation ID နဲ့ ရှာနိုင်ရမယ်။
- **ဖတ်ရန်** [Microsoft Transactional Outbox](https://learn.microsoft.com/en-us/azure/architecture/databases/guide/transactional-outbox-cosmos) (နမူနာမှာ Cosmos DB သုံးပြီး Lab မှာ SQL Server transaction သို့ ပြောင်းသုံးပါ) · [RabbitMQ Confirms and Acknowledgements](https://www.rabbitmq.com/docs/confirms)

### ပတ် 14 — Caching၊ queries နှင့် performance

- **ရည်မှန်းချက်** Read path တိုးတက်မှုကို တိုင်းတာပြီး လက်ကျန်မှန်ကန်မှုကို ထိန်းနိုင်မယ်။
- **သီအိုရီ** Cache-aside၊ TTL၊ invalidation၊ cache stampede၊ DB indexes/query plans၊ keyset pagination၊ p50/p95 latency။
- **လုပ်ငန်းစဉ်** Product catalog request → Redis hit သို့ DB fetch → cache fill။ Catalog update → DB commit → cache invalidate။ Cache outage → DB fallback။
- **Lab** Catalog ကို Redis cache လုပ်ပါ။ Statement read အတွက် account + posting sequence index၊ unique sort order နှင့် cursor pagination ထည့်ပါ။ Seed 10,000 journal lines ဖြင့် cold/warm latency၊ query count နှင့် plan စစ်ပါ။
- **ပေးပို့ရန်** Benchmark table၊ cache key/TTL docs၊ index plan နဲ့ outage evidence။
- **လက်ခံစံ** Warm catalog requests ၁၀၀ တွင် cache hit ≥ ၉၀ ဖြစ်ရမယ်။ Cache ပိတ်ချိန် catalog DB မှရပြီး transfer validation ရလဒ် တူရမယ်။ တူညီတဲ့ dataset ပေါ် statement pages ဆက်ဖတ်ရာ duplicate/skip 0။
- **ဖတ်ရန်** [Microsoft Cache-Aside Pattern](https://learn.microsoft.com/en-us/azure/architecture/patterns/cache-aside) · [Redis Key Expiration](https://redis.io/docs/latest/commands/expire/) · [EF Core Pagination](https://learn.microsoft.com/en-us/ef/core/querying/pagination)

### ပတ် 15 — Testing၊ observability နှင့် release rehearsal

- **ရည်မှန်းချက်** Regression နှင့် failure recovery ကို CI နဲ့ telemetry မှတစ်ဆင့် ပြန်စစ်နိုင်မယ်။
- **သီအိုရီ** Unit/invariant tests၊ real SQL Server integration၊ UI E2E၊ contract tests၊ structured logs၊ metrics၊ distributed tracing၊ liveness/readiness။
- **လုပ်ငန်းစဉ်** Commit → build/test → temporary environment → smoke tests → failure injection → trace ဖြင့် root cause ရှာ။
- **Lab** CI တွင် ledger invariant၊ migrations၊ duplicate/concurrent transfer၊ payment callback၊ reconciliation နှင့် authorization tests run ပါ။ OpenTelemetry trace ကို API → worker အထိ ချိတ်ပါ။ Retry count၊ oldest outbox age၊ reconciliation breaks နဲ့ error/latency metrics ထည့်ပါ။
- **ပေးပို့ရန်** CI workflow၊ acceptance test matrix၊ telemetry screenshot၊ incident rehearsal report။
- **လက်ခံစံ** Clean checkout မှ pipeline green ဖြစ်ရမယ်။ SQL Server မရချိန် readiness fail ဖြစ်ပြီး process liveness သီးခြားစစ်နိုင်ရမယ်။ Sample transaction တစ်ခုကို request ID မှ journal၊ outbox နှင့် worker trace အထိ ချိတ်ပြနိုင်ရမယ်။
- **ဖတ်ရန်** [ASP.NET Core Integration Tests](https://learn.microsoft.com/en-us/aspnet/core/test/integration-tests) · [OpenTelemetry .NET](https://opentelemetry.io/docs/languages/dotnet/) · [GitHub Actions for .NET](https://docs.github.com/en/actions/use-cases-and-examples/building-and-testing/building-and-testing-net)

### ပတ် 16 — Production deployment နှင့် capstone demo

- **ရည်မှန်းချက်** Production release လုပ်ငန်းစဉ်ကို staging မှာ အစအဆုံး ပြနိုင်မယ်။
- **သီအိုရီ** Immutable artifacts၊ secrets/config၊ reviewed migrations၊ backward-compatible schema change၊ release/rollback၊ backup/restore၊ RPO/RTO နှင့် alert ownership။
- **လုပ်ငန်းစဉ်** Build versioned artifacts → backup → review/apply migration → API/UI/worker deploy → smoke → metrics check → rollback rehearsal → restore drill။
- **Lab** Docker Compose ဖြင့် staging တည်ဆောက်ပါ။ DB migration ကို သီးခြား release step မှာ run ပါ။ Backward-compatible migration သုံးပြီး prior app version ပြန်တင်ပါ။ Backup ကို သီးသန့် DB သို့ restore လုပ်၍ journal counts/totals နှင့် latest recoverable business date စစ်ပါ။ Recovery time နှင့် ပြန်ရသော data point ကို မှတ်ပါ။
- **ပေးပို့ရန်** Tagged release၊ setup/deploy README၊ migration plan၊ monitoring/incident runbook၊ restore evidence၊ capstone demo။
- **လက်ခံစံ** Fresh environment မှ documented commands နဲ့ start လုပ်နိုင်ရမယ်။ KYC → deposit → duplicate-safe transfer → external payment settlement → reconciliation ကို demo ပြနိုင်ရမယ်။ Rollback ပြီး existing journals ဖတ်နိုင်ရမယ်။ Restore ပြီး ledger/subledger totals ညီရမယ်။ Lab target RTO ≤ ၃၀ မိနစ်၊ RPO ≤ ၁၅ မိနစ်ကို တိုင်းပြီး evidence မှတ်ပါ။ မပြည့်လျှင် backup cadence သို့ runbook ပြင်ပြီး ထပ်စမ်းပါ။
- **ဖတ်ရန်** [Docker Compose](https://docs.docker.com/compose/) · [EF Core Applying Migrations](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/applying) · [SQL Server Backup and Restore](https://learn.microsoft.com/en-us/sql/relational-databases/backup-restore/back-up-and-restore-of-sql-server-databases)

## Milestones

| ပြီးမည့်ပတ် | စုစုပေါင်းနာရီ | Demo | အတည်ပြုမည့် evidence |
|---|---:|---|---|
| 04 | 72 | Deposit ကို DB ထဲ post လုပ်ပြီး trial balance ထုတ် | Worksheet၊ fresh/upgrade migration test၊ rollback test |
| 08 | 144 | UI မှ same-bank transfer နဲ့ timeout retry | Receipt တစ်ခု၊ duplicate/80.00 race tests၊ projection မှန်ကန်မှု |
| 12 | 216 | Mock provider settlement၊ reconciliation၊ compliance review | Matched/exception report၊ role tests၊ audit trail |
| 16 | 288 | Staging capstone နှင့် recovery drill | CI results၊ trace၊ rollback/restore report၊ release tag |

## ပြန်သုံးနိုင်သော Checklists

### Posting နှင့် ငွေလွှဲ စစ်ဆေးရန်

- [ ] Business event၊ currency၊ amount၊ effective date နဲ့ expected debit/credit ကို fixture ထဲ အရင်မှတ်ထားသည်။
- [ ] Valid journal ကိုသာ commit လုပ်ပြီး failure မှာ related writes အားလုံး rollback ဖြစ်သည်။
- [ ] Posted data ပြင်ရန် linked reversal/adjustment journal သုံးသည်။ App database role ကို direct posted update/delete ခွင့်မပေးထား။
- [ ] Duplicate key၊ conflicting payload၊ response loss နဲ့ concurrent spend တို့ကို SQL Server မှာ စစ်ထားသည်။
- [ ] Ledger ကနေ balance projection၊ statement နဲ့ GL control ကို ပြန်ထုတ်နိုင်သည်။

### Payments၊ reconciliation နှင့် operations စစ်ဆေးရန်

- [ ] State transition တစ်ခုချင်းစီမှာ allowed actor၊ precondition၊ posting effect နှင့် retry behavior သတ်မှတ်ထားသည်။
- [ ] Unknown outcome ကို provider reference ဖြင့် status ပြန်စစ်နိုင်သည်။ Duplicate/out-of-order event ဖြင့် posting မထပ်။
- [ ] Statement batch control totals၊ cut-off၊ unmatched lines နှင့် resolution history မှတ်ထားသည်။
- [ ] Operator၊ checker၊ auditor ခွင့်ပြုချက်များကို API test ဖြင့် အတည်ပြုပြီး logs တွင် PII masking စစ်ထားသည်။

### Release စစ်ဆေးရန်

- [ ] CI green၊ artifact version၊ config/secrets၊ migration review နှင့် smoke steps မှတ်ထားသည်။
- [ ] Readiness၊ error rate၊ outbox lag၊ reconciliation break metrics နှင့် alert owner သိနိုင်သည်။
- [ ] Rollback အပြီး schema နှင့် app version လိုက်ဖက်ကြောင်း စမ်းထားသည်။
- [ ] Backup restore ကို သီးသန့် environment မှာ ပြန်လုပ်ပြီး journal totals၊ elapsed recovery time နှင့် recoverable data point မှတ်ထားသည်။

## Progress Tracker

အပတ်တိုင်း **မစရသေး / လုပ်ဆဲ / စစ်ဆေးဆဲ / ပြီး** တစ်ခု သတ်မှတ်ပါ။ Acceptance checks ဖြတ်ပြီး evidence တင်ထားမှ **ပြီး** လို့ မှတ်ပါ။ Progress ကို ပြီးသောအပတ် ÷ ၁၆ ဖြင့်တွက်ပြီး အမှန်တကယ်သုံးသော နာရီကို ၂၈၈ နဲ့ သီးခြားယှဉ်ပါ။

| ပတ် | ရည်မှန်းနာရီ | အမှန်နာရီ | အခြေအနေ | Evidence / ကျန်အလုပ် |
|---|---:|---:|---|---|
| 01 | 18 | — | မစရသေး | |
| 02 | 18 | — | မစရသေး | |
| 03 | 18 | — | မစရသေး | |
| 04 | 18 | — | မစရသေး | |
| 05 | 18 | — | မစရသေး | |
| 06 | 18 | — | မစရသေး | |
| 07 | 18 | — | မစရသေး | |
| 08 | 18 | — | မစရသေး | |
| 09 | 18 | — | မစရသေး | |
| 10 | 18 | — | မစရသေး | |
| 11 | 18 | — | မစရသေး | |
| 12 | 18 | — | မစရသေး | |
| 13 | 18 | — | မစရသေး | |
| 14 | 18 | — | မစရသေး | |
| 15 | 18 | — | မစရသေး | |
| 16 | 18 | — | မစရသေး | |
| **စုစုပေါင်း** | **288** | — | **0/16** | |

### အပတ်စဉ် Review Template

- ပတ် / ရက်စွဲ / သုံးခဲ့သောနာရီ —
- ကိုယ်တိုင်ရှင်းပြနိုင်သော business rule —
- Demo၊ commit သို့မဟုတ် test report link —
- Acceptance check ရလဒ်နှင့် dataset —
- မအောင်မြင်သေးသည့် case နှင့် ပြန်စမ်းမည့်နည်း —
- နောက်အပတ်မစမီ ပြီးရမည့်အလုပ် —
