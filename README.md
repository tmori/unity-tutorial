# Unity で物理シミュレーションするための基礎知識を学ぶためのチュートリアル

[TOPPERSプロジェクト箱庭WG](https://toppers.github.io/hakoniwa/)では、Unityを利用したシミュレーション環境を提供しています。
本リポジトリでは、箱庭で頻繁に利用する物理シミュレーションに焦点をあてて、そもそも「Unityって何？」、「どうやって使うの？」という方に向けたチュートリアルを公開しています。

# 想定する PC 環境

* Windows 環境：Windows 10/11
  * Ubuntu 22.04 LTS on WSL2/WSLg
* Linux 環境：Ubuntu 20.04 LTS
* Mac 環境
  * Intel
    * macOS Catalina ver.10.15.7 以降
  * Applesilicon
  
# PC環境の準備
 
## 本リポジトリの clone 
ターミナルで下記を実行して本リポジトリを clone してください。

```
git clone https://github.com/tmori/unity-tutorial.git
```

## Unity 環境のインストール

* Unity Hub 3.1.1 以降
* Unity Editor 2021.3.17f1 以降

# 本プロジェクトを Unity Editor で開く

Unity Hub を起動し、右上の「開く」をクリックして、先ほどクローンしたソースの以下のディレクトリを指定します。

場所：unity-tutorial/sample

![image](https://user-images.githubusercontent.com/164193/230744516-80cf90ab-3b85-4804-aaa7-e2c9ecdb5485.png)

起動すると以下の画面が表示されます。

![image](https://user-images.githubusercontent.com/164193/230744569-865baf9c-5a78-4fbb-86cf-15c014544437.png)

この状態で、画面左下にある「Projectビュー」の「Assets/Scenes」を選択すると、画面左下にチュートリアル用のシーンがありますので、01_zoom をダブルクリックしましょう。

![image](https://user-images.githubusercontent.com/164193/230744610-2932f162-f0f4-4e49-bed4-52eeac2f74f4.png)

以下のように、キューブが現れたら成功です。

![image](https://user-images.githubusercontent.com/164193/230744627-c6280610-a64f-4976-815a-7653d26434d5.png)

