<h1 align="center">
  遊戲開發CICD範例
</h1>

## 前言
這個範例是依據我們專案的CICD需求所設計，這邊也記錄一些基礎知識，
包含使用的工具、Unity自動化建置、測試等。

## Github Action
原先我們使用Jenkins，但使用Github Action可以使工作更集中在統一的系統上。

Github Action是個非常容易使用的Github Repository自動化服務。
通常是透過Github提供的虛擬機/容器執行，但也能使用自己的PC/MAC運行(Self-Hosted Runner)，
再透過Github Action調用。

使用Github提供的虛擬機，每次進行CI建置時都是從乾淨的空容器開始，
當專案規模太大時，每次重新開啟容器、導入Libary或額外的工具，會導致CI時間相對長，
Self-Hosted就可以簡單的只對差異的部分進行建置，機器的性能也能弄得比虛擬機好。

Github Action的虛擬機並非完全免費，每個月有限額度(免費版一個月2000分鐘)。 
Linux外的虛擬機的費用是非常高的(Windows兩倍、MacOS10倍)，
這也是其中一個我們選擇Self-Hosted的原因。

- [關於Github Action的付費(官方文件)](https://docs.github.com/cn/free-pro-team@latest/github/setting-up-and-managing-billing-and-payments-on-github/about-billing-for-github-actions)

## 用途
當Pull Request在指定Branch發生時:
1. Checkout指定Branch的Repository至 `$GITHUB_WORKSPACE`
2. 跑Unity TestRun PlayMode以及EditorMode
3. 移除上次Build的檔案
4. Unity Build Windows與Switch版本
5. 以上成功後，自動Merge
   如果以上失敗會在Discord進行失敗通知

當Merge成功時:
1. 刪除已經Merge的Pull Request來源Branch
2. 將Windows Build上傳至Steam
3. 依照PullRequest的內容自動更新Release Note草稿
4. 在Disocrd進行成功通知

##限制
如果你使用的是Unity Personal版本，大中華區的用戶有每三日需要登入一次的問題。

## 依賴的Action
| Action  | 用途  | 狀態 |
| ------------ | ------------ | ----------|
| [Checkout](https://github.com/actions/checkout "Checkout")| 將Repository checks-out 至 `$GITHUB_WORKSPACE` 下 | ![Build Status](https://github.com/actions/checkout/workflows/test-local/badge.svg)|
| <a href="https://github.com/release-drafter/release-drafter">Release Drafter</a>  | 依照Pull Reqeust的資訊，自動產生Release Note  ||
| [Actions Status Discord](https://github.com/sarisia/actions-status-discord "Actions Status Discord")  | 透過Webhook在Discord發出訊息  ||
| [Automerge-action](https://github.com/pascalgn/automerge-action "Automerge-action")  | 自動Merge Pull Request  ||
| [Remove File](https://github.com/JesseTG/rm "Remove File")  | 全平台移除檔案或資料夾  ||
| [Delete merged branch](https://github.com/SvanBoxel/delete-merged-branch "Delete merged branch")  | 移除Merge後的Branch  |![Build Status](https://github.com/SvanBoxel/delete-merged-branch/workflows/Test%20bot%20e2e/badge.svg)|


## 設定
* [設定Self-Hosted Runner](#設定self-hosted-runner)
* [WorkFlow設定](#workflow設定)
     * [OnPullRequest](#onpullrequest)
     * [DeleteBranchOnClose](#deletebranchonclose)
     * [Deploy](#deploy)
* [Release Drafter設定](#release-drafter設定)
* [Steam Deploy設定](#steam-deploy設定)
* [Unity Build Script設定](#unity-build-script設定)
* [Discord Webhook設定](#discord-webhook設定)
* [Github Secrect設定](#github-secrect設定)


### 設定Self-Hosted Runner
1. 開啟Github Repository網頁 `Settings` > `Actions`
2. `Self-hosted runners` 的欄位中選擇 `Add runner` 按鈕
3. 打開 PowerShell 移動到系統根目錄(例:C:\)，按照頁面設定 (跟著複製貼上就對了)

最後會問你 「Would you like to run the runner as service? (Y/N)」
如果你回答Y，那這個Runner將會以Windows服務的形式，在背景運行。




### WorkFlow設定


#### OnPullRequest


#### DeleteBranchOnClose


#### Deploy


### Release Drafter設定


### Steam Deploy設定


### Unity Build Script設定


### Discord Webhook設定


### Github Secrect設定


##參考
[GitHub Actions のセルフホストランナーで Unity ビルドする](https://framesynthesis.jp/tech/github/actions-unity/)