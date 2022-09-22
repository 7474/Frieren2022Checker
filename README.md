# Frieren2022Checker

葬送のフリーレン人気投票（ https://websunday.net/frieren2022/ ）の1000票、10000票ツイートを収集するツール。

## Usage

Azure Functionsです。

Twitterの認証情報を構成して適当に実行してください。

```sh
$ curl -X POST http://localhost:7071/api/Frieren2022Checker
{"sen":[{"target":"フリーレン","count":59000},{"target":"ヒンメル","count":44000},{"target":"フェルン","count":40000},{"target":"デンケン","count":26000},{"target":"シュタルク","count":22000},{"target":"断頭台のアウラ","count":19000},{"target":"ミミック","count":18000},{"target":"南の勇者","count":18000},{"target":"ザイン","count":16000},{"target":"フランメ","count":11000},{"target":"ハイター","count":11000},{"target":"ユーベル","count":10000},{"target":"馬鹿みたいにでかいハ ンバーグ","count":8000},{"target":"ゼーリエ","count":8000},{"target":"ジャンボベリースペシャル","count":7000},{"target":"黄金郷のマハト","count":6000},{"target":"剣の里の里長","count":6000},{"target":"ソリテール","count":5000},{"target":"メトーデ","count":5000},{"target":"エーデル","count":4000},{"target":"クラフト","count":4000},{"target":"ゼンゼ","count":4000},{"target":"ヴィアベル","count":4000},{"target":"荒くれ者たち","count":4000},{"target":"ラヴィーネ","count":3000},{"target":"クソみたいな驕りと油断で死んだ魔族","count":3000},{"target":"アイゼン","count":3000},{"target":"リーニエ","count":3000},{"target":"武のおじいさん","count":3000},{"target":"グラナト伯爵","count":2000},{"target":"水鏡の悪魔","count":2000},{"target":"隕鉄鳥","count":2000},{"target":"大陸魔法協会受付のお姉さん","count":2000},{"target":"フリーレンのスカ ートを捲ったクソガキ","count":2000},{"target":"ラオフェン","count":2000},{"target":"ルーフェン地方を襲う魔族2","count":2000},{"target":"フォル 爺","count":2000},{"target":"シュトルツ","count":1000},{"target":"オルデン卿","count":1000},{"target":"ザインの兄","count":1000},{"target":"脱出用ゴーレム","count":1000},{"target":"カンネ","count":1000},{"target":"ドゥンスト","count":1000},{"target":"ゲナウ","count":1000},{"target":"フリュー","count":1000},{"target":"ミリアルデ","count":1000},{"target":"グラナト伯爵領の庭師","count":1000},{"target":"ラヴィーネの長 兄","count":1000},{"target":"レルネン","count":1000},{"target":"レヴォルテ配下の魔族","count":1000},{"target":"腐敗の賢老クヴァール","count":1000},{"target":"ブ ルグ","count":1000},{"target":"グリュック","count":1000},{"target":"マハト","count":1000},{"target":"リュグナー","count":1000}],"man":[{"target":"フリーレン","count":2510000},{"target":"ヒンメル","count":1570000},{"target":"フェルン","count":1450000},{"target":"シュタルク","count":630000},{"target":"デンケン","count":620000},{"target":"ミミック","count":550000},{"target":"黄金郷のマハト","count":420000},{"target":"断頭台のアウラ","count":380000},{"target":"南の 勇者","count":360000},{"target":"ザイン","count":350000},{"target":"メトーデ","count":250000},{"target":"ゼーリエ","count":220000},{"target":"ハイター","count":200000},{"target":"ソリテール","count":190000},{"target":"ユーベル","count":170000},{"target":"フランメ","count":150000},{"target":"ヴィアベル","count":140000},{"target":"ゼンゼ","count":130000},{"target":"腐敗の賢 老クヴァール","count":120000},{"target":"馬鹿みたいにでかいハンバーグ","count":120000},{"target":"剣の里の里長","count":110000},{"target":"ジャンボベリースペシャル","count":110000},{"target":"アイゼン","count":110000},{"target":"グリュック","count":80000},{"target":"ラヴィーネ","count":70000},{"target":"フリーレンのスカートを捲ったクソガキ","count":70000},{"target":"武のおじいさん","count":70000},{"target":"脱出用ゴーレム","count":70000},{"target":"マハト","count":70000},{"target":"クソみたいな驕りと油断で死んだ魔族","count":60000},{"target":"ルーフェン地方を襲う魔族2","count":60000},{"target":"大陸魔法協会受付のお姉さん","count":60000},{"target":"エーデル","count":60000},{"target":"荒くれ者たち","count":50000},{"target":"リーニエ","count":50000},{"target":"クラフト","count":50000},{"target":"レクテューレ","count":40000},{"target":"ラオフェン","count":40000},{"target":"レルネン","count":40000},{"target":"レンゲ","count":40000},{"target":"レヴォルテ配下の魔族","count":40000},{"target":"戦士ゴリラ","count":40000},{"target":"シュトルツ","count":40000},{"target":"ミリアルデ","count":30000},{"target":"ゲナウ","count":30000},{"target":"リヒター","count":30000},{"target":"ツイートと葬送のフリーレンフォローで10000票","count":30000},{"target":"葬送のフリーレン","count":30000},{"target":"カンネ","count":20000},{"target":"暗黒竜の角","count":20000},{"target":"ブルグ","count":20000},{"target":"剣の魔族","count":10000},{"target":"ターク地方の薬草家","count":10000},{"target":"フリーレンアニメ化 記念キャラ人気投票","count":10000},{"target":"水鏡の悪 魔","count":10000},{"target":"フリュー","count":10000},{"target":"シードラット","count":10000},{"target":"ルーフェン地方を襲う魔族1","count":10000},{"target":"ガーベル","count":10000},{"target":"リュグナー","count":10000}]}
```
