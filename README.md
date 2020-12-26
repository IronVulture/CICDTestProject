<h1 align="center">
  遊戲開發CICD範例
</h1>



## 依賴的Action
| Action  | 用途  | 狀態 |
| ------------ | ------------ | ----------|
| [Checkout](https://github.com/actions/checkout "Checkout")| 將Repository checks-out 至 `$GITHUB_WORKSPACE` 下 | ![Build Status](https://github.com/actions/checkout/workflows/test-local/badge.svg)|
| <a href="https://github.com/release-drafter/release-drafter">Release Drafter</a>  | 依照Pull Reqeust的資訊，自動產生Release Note  ||
| [Actions Status Discord](https://github.com/sarisia/actions-status-discord "Actions Status Discord")  | 透過Webhook在Discord發出訊息  ||
| [Automerge-action](https://github.com/pascalgn/automerge-action "Automerge-action")  | 自動Merge Pull Request  ||
| [Remove File](https://github.com/JesseTG/rm "Remove File")  | 全平台移除檔案或資料夾  ||
| [Delete merged branch](https://github.com/SvanBoxel/delete-merged-branch "Delete merged branch")  | 移除Merge後的Branch  |![Build Status](https://github.com/SvanBoxel/delete-merged-branch/workflows/Test%20bot%20e2e/badge.svg)|

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


## 設定


   * [設定Self Host Runner](#設定self-host-runner)
   * [WorkFlow設定](#workflow設定)
        * [OnPullRequest](#onpullrequest)
        * [DeleteBranchOnClose](#deletebranchonclose)
        * [Deploy](#deploy)
   * [Release Drafter設定](#release-drafter設定)
   * [Steam Deploy設定](#steam-deploy設定)
   * [Unity Build Script設定](#unity-build-script設定)
   * [Discord Webhook設定](#discord-webhook設定)
   * [Github Secrect設定](#github-secrect設定)


### 設定Self Host Runner


### WorkFlow設定


#### OnPullRequest


#### DeleteBranchOnClose


#### Deploy


### Release Drafter設定


### Steam Deploy設定


### Unity Build Script設定


### Discord Webhook設定


### Github Secrect設定
