# 作業一

- 步驟一 設定port4000
    - 建立asp.net core api，在方案總管尋找properties的資料夾下的....josn文件，設定"applicationUrl": "http://localhost:4000"

- 步驟二 顯示Hello world
    -  在Controllers資料夾案右鍵選加入在選新增項目在選API控制器，檔名取helloworld.cs，在打上程式碼
```程式類型
 public class helloworld : ControllerBase
 {
     public helloworld() { }

     [HttpGet]
     public string hellowold()
     {
         return "Hellow world";
     }
 }
```

- 步驟三 下載Ngrok並連接port4000

[Ngrok][1]

  [1]: https://ngrok.com/        "Ngrok"
    - 註冊並申請Authtoken，在終端機進入Ngork資料夾，並輸入ngrok authtoken YOUR_AUTH_TOKEN，再輸入ngrok http 4000，就可以得到Ngrok的網址，拿網址後面再加上/helloworld就可以成功了。
## 畫面
![Ngrok的網址](./image/01.png)
![成功完成](./image/02.png)
