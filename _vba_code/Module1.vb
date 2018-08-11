Attribute VB_Name = "Module1"
Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

Sub Auto_Open()
  AddCellsMenu
End Sub

Sub Auto_Close()
  ResetCellsMenu
End Sub


'*****************************************
' メニューをリセットするマクロ
'*****************************************
Sub ResetCellsMenu()
  Application.CommandBars("Cell").Reset
End Sub

'*****************************************
' メニューをカスタマイズするマクロ
'*****************************************
Private Sub AddCellsMenu()
  'セルのメニューに追加することを明示
  Dim CellMenuObj As Variant
  
 
' **************************
' セルの右クリックメニュー
' **************************

'  '新しい右クリックメニューを追加
'  Set CellMenuObj = Application.CommandBars("Cell").Controls.Add(Type:=msoControlButton)
'  With CellMenuObj
'    .Caption = "command sentence"
'    .OnAction = "function name"
'    .BeginGroup = False / True
'  End With


  '新しい右クリックメニューを追加
  Set CellMenuObj = Application.CommandBars("Cell").Controls.Add(Type:=msoControlButton)
  With CellMenuObj
    .Caption = "セルの結合／分割"
    .OnAction = "CELL_MERGING"
    .BeginGroup = True
  End With

  '新しい右クリックメニューを追加
  Set CellMenuObj = Application.CommandBars("Cell").Controls.Add(Type:=msoControlButton)
  With CellMenuObj
    .Caption = "クイックオートフィル"
    .OnAction = "QUICK_FILL"
    .BeginGroup = False
  End With


  '新しい右クリックメニューを追加
  Set CellMenuObj = Application.CommandBars("Cell").Controls.Add(Type:=msoControlButton)
  With CellMenuObj
    .Caption = "特定のデータを数える"
    .OnAction = "DataCellCount"
    .BeginGroup = False
  End With


  '新しい右クリックメニューを追加
  Set CellMenuObj = Application.CommandBars("Cell").Controls.Add(Type:=msoControlButton)
  With CellMenuObj
    .Caption = "ブラウザを選択して開く"
    .OnAction = "SelectBrowser"
    .BeginGroup = False
  End With

  '新しい右クリックメニューを追加
  Set CellMenuObj = Application.CommandBars("Cell").Controls.Add(Type:=msoControlButton)
  With CellMenuObj
    .Caption = "JISX8341-3ツール"
    .OnAction = "JisDiagRun"
    .BeginGroup = False
  End With
  
End Sub

'*****************************************
'   ブラウザを選択して開くダイアログ
'*****************************************
Sub SelectBrowser()
    SBDiag.Show False
End Sub


'*****************************************
' IE Object Init
'*****************************************
Sub init_IE()
    Dim oIE As Object
    Set oIE = CreateObject("InternetExploler.application.1")
End Sub

'*****************************************
' IE Object Destroy
'*****************************************
Sub destroy_IE()
    Set oIE = Nothing
End Sub

'*****************************************
' 複数のセルが選択されているか判定する
' cellRangeCount()
'*****************************************
Function cellRangeCount()
    cellRangeCount = Selection.Columns.Count
End Function

'*****************************************
' セル値の結合
' cellValueMerge(str 接続記号や文字)
'*****************************************
Function cellValueMerge(str As String)
    Dim x, y As Long
    x = Selection.Columns.Count
    y = Selection.Rows.Count
    If Not y > 1 Then
        cellValueMerge = Selection.Cells(1, 1).Value & _
        str & Selection.Cells(1, 2).Value
    Else
        cellValueMerge = ""
    End If
End Function

'****************************************************************
' 正規表現でデータを判定する
'  function DoRegExp(str 正規表現パターン, str 調査対象文字列)
'****************************************************************
Function DoRegExp(strPattern As String, strMain As String)
    Set RE = CreateObject("VBScript.RegExp")
    With RE
        .Pattern = strPattern
        .IgnoreCase = True
        .Global = True
         Set reMatch = .Execute(strMain)
         If reMatch.Count = 0 Then
                DoRegExp = False
         Else
                DoRegExp = True
         End If
    End With
End Function

'******************************************
' セルのハイパーリンクを取得する
' GetCellHref()
'******************************************

Function GetCellHref()

    Dim Obj As Range
    Dim item As Hyperlink
    Dim AddressStr As String
    Set Obj = Selection
    
    If Selection.Columns.Count > 1 Or _
        Selection.Rows.Count > 1 Then
        MsgBox "複数選択には対応しません。"
        Exit Function
    End If
   
    
    For Each item In Obj.Hyperlinks
        AddressStr = item.Address
    Next
    
    GetCellHref = AddressStr
        
End Function

'****************************************************
' Homepage Reader 3.01 でURLを開くマクロ HPR_EXEC()
'****************************************************
Sub HPR_EXEC()
    Dim myID As Double 'アプリケーションID
    Dim strURL As String 'URL
    'アクティブセルから文字列を抽出
    If cellRangeCount > 1 Then
        strURL = cellValueMerge("\")
    Else
        strURL = ActiveCell.Value
    End If

    '正規判定
    'ＵＲＬであるかどうか
    If DoRegExp("^(http://|https://).+", strURL) = True Then
        strURL = Replace(strURL, "\", "/")
    'ファイルパスであるかどうか
    ElseIf DoRegExp("^[a-zA-Z]:\\", strURL) = True Then
        'パスの末尾がHTML関係のファイル拡張子であるかどうか
        If DoRegExp("\.(htm|html|css|php|cgi)$", strURL) = True Then
            strURL = strURL
        Else
            MsgBox "不正なファイルパスが選択されています。選択しなおしてください。"
            Exit Sub
        End If
    ElseIf Not GetCellHref() = "" Then
            strURL = GetCellHref()
    Else
        MsgBox "不正なファイルパスが選択されています。選択しなおしてください。"
        Exit Sub
    End If

    'shell関数でHomePageReaderを起動する
    On Error Resume Next
    myID = Shell("C:\Program Files\IBM\HPR3\hpr.exe " & strURL, vbNormalNoFocus)
End Sub


'*****************************************
' FirefoxでURLを開くマクロ FOX_EXEC()
'*****************************************

Sub FOX_EXEC()
    Dim myID As Double 'アプリケーションID
    Dim strURL As String 'URL
    'アクティブセルから文字列を抽出
    If cellRangeCount > 1 Then
        strURL = cellValueMerge("\")
    Else
            strURL = ActiveCell.Value
    End If

    '正規判定
    'ＵＲＬであるかどうか
    If DoRegExp("^(http://|https://).+", strURL) = True Then
        strURL = Replace(strURL, "\", "/")
    'ファイルパスであるかどうか
    ElseIf DoRegExp("^[a-zA-Z]:\\", strURL) = True Then
        'パスの末尾がHTML関係のファイル拡張子であるかどうか
        If DoRegExp("\.(htm|html|css|php|cgi)$", strURL) = True Then
            strURL = strURL
        Else
            MsgBox "不正なファイルパスが選択されています。選択しなおしてください。"
            Exit Sub
        End If
    ElseIf Not GetCellHref() = "" Then
            strURL = GetCellHref()
    Else
        MsgBox "不正なファイルパスが選択されています。選択しなおしてください。"
        Exit Sub
    End If

    'shell関数でFirefoxを起動する
    On Error Resume Next
    '32bit Windowsの場合
    If GetWinBitNum = "32" Then
        myID = Shell("C:\Program Files\Mozilla Firefox\firefox.exe -new-tab " & strURL, vbNormalNoFocus)
    '64bit Windowsの場合
    Else
        myID = Shell("C:\Program Files (x86)\Mozilla Firefox\firefox.exe -new-tab " & strURL, vbNormalNoFocus)
    End If
End Sub


'*****************************************
' Lynx でURLを開くマクロ LYNX_EXEC()
'*****************************************
Sub LYNX_EXEC()
    Dim myID As Double 'アプリケーションID
    Dim strURL As String 'URL
    'アクティブセルから文字列を抽出
    If cellRangeCount > 1 Then
        strURL = cellValueMerge("\")
    Else
        strURL = ActiveCell.Value
    End If

    '正規判定
    'ＵＲＬであるかどうか
    If DoRegExp("^(http://|https://).+", strURL) = True Then
        strURL = Replace(strURL, "\", "/")
    'ファイルパスであるかどうか
    ElseIf DoRegExp("^[a-zA-Z]:\\", strURL) = True Then
        'パスの末尾がHTML関係のファイル拡張子であるかどうか
        If DoRegExp("\.(htm|html|css|php|cgi)$", strURL) = True Then
            strURL = strURL
        Else
            MsgBox "不正なファイルパスが選択されています。選択しなおしてください。"
            Exit Sub
        End If
    ElseIf Not GetCellHref() = "" Then
            strURL = GetCellHref()
    Else
        MsgBox "不正なファイルパスが選択されています。選択しなおしてください。"
        Exit Sub
    End If

    'shell関数でLynxを起動する
    On Error Resume Next
    '32bit Windowsの場合
    If GetWinBitNum = "32" Then
        myID = Shell("C:\Program Files\Lynx for Win32\lynx.exe " & strURL, vbNormalNoFocus)
    '64bit Windowsの場合
    Else
        myID = Shell("C:\Program Files(x86)\Lynx for Win32\lynx.exe " & strURL, vbNormalNoFocus)
    End If
End Sub



'*****************************************
' ファイルパスをIEで開く IE_EXEC()
'*****************************************
Sub IE_EXEC()
    Dim strURL As String 'URL
    'アクティブセルから文字列を抽出
    If cellRangeCount > 1 Then
        strURL = cellValueMerge("\")
    Else
        strURL = ActiveCell.Value
    End If

    '正規判定
    'ＵＲＬであるかどうか
    If DoRegExp("^(http://|https://).+", strURL) = True Then
        strURL = Replace(strURL, "\", "/")
    'ファイルパスであるかどうか
    ElseIf DoRegExp("^[a-zA-Z]:\\", strURL) = True Then
        'パスの末尾がHTML関係のファイル拡張子であるかどうか
        If DoRegExp("\.(htm|html|css|php|cgi)$", strURL) = True Then
            strURL = strURL
        Else
            MsgBox "不正なファイルパスが選択されています。選択しなおしてください。"
            Exit Sub
        End If
    ElseIf Not GetCellHref() = "" Then
            strURL = GetCellHref()
    Else
        MsgBox "不正なファイルパスが選択されています。選択しなおしてください。"
        Exit Sub
    End If

'ＩＥオブジェクトの作成
Dim oIE As Object
Set oIE = CreateObject("InternetExplorer.Application.1")

oIE.Navigate2 strURL
oIE.Visible = True

End Sub

'*****************************************
' Google ChromeでURLを開くマクロ LYNX_EXEC()
'*****************************************
Sub GC_EXEC()
    Dim myID As Double 'アプリケーションID
    Dim strURL As String 'URL
    'アクティブセルから文字列を抽出
    If cellRangeCount > 1 Then
        strURL = cellValueMerge("\")
    Else
        strURL = ActiveCell.Value
    End If

    '正規判定
    'ＵＲＬであるかどうか
    If DoRegExp("^(http://|https://).+", strURL) = True Then
        strURL = Replace(strURL, "\", "/")
    'ファイルパスであるかどうか
    ElseIf DoRegExp("^[a-zA-Z]:\\", strURL) = True Then
        'パスの末尾がHTML関係のファイル拡張子であるかどうか
        If DoRegExp("\.(htm|html|css|php|cgi)$", strURL) = True Then
            strURL = strURL
        Else
            MsgBox "不正なファイルパスが選択されています。選択しなおしてください。"
            Exit Sub
        End If
    ElseIf Not GetCellHref() = "" Then
            strURL = GetCellHref()
    Else
        MsgBox "不正なファイルパスが選択されています。選択しなおしてください。"
        Exit Sub
    End If
    
    'ユーザディレクトリを取得する
    Dim wScriptHost As Object
    Dim Desktop2Dir, User2Dir, Path2GC, GCInstallPath As String
    
    Set wScriptHost = CreateObject("WScript.Shell")
       
    Desktop2Dir = wScriptHost.SpecialFolders("Desktop")
    
    'OSのバージョン判定
    
    If GetWinVer() Like "7*" Or GetWinVer() Like "Vista*" Then
        User2Dir = Replace(Desktop2Dir, "Desktop", "")
        Path2GC = "AppData\Local\Google\Chrome\Application\chrome.exe"
    ElseIf GetWinVer() Like "XP*" Or GetWinVer() Like "2000*" Then
        User2Dir = Replace(Desktop2Dir, "デスクトップ", "")
        Path2GC = "Local Settings\Application Data\Google\Chrome\Application\chrome.exe"
    Else
        MsgBox "現在お使いのＯＳには対応していません。"
        Exit Sub
    End If
    
    GCInstallPath = User2Dir & Path2GC


    'shell関数でGoogleChromeを起動する
    On Error Resume Next
    myID = Shell(GCInstallPath & " " & strURL, vbNormalNoFocus)
End Sub


'**********************************************
' Windowsのバージョンを取得する関数
'**********************************************
Function GetWinVer()

    Dim Locator, Service, OsSet, os, msg As String
    Set Locator = CreateObject("WbemScripting.SWbemLocator")
    Set Service = Locator.ConnectServer
    Set OsSet = Service.ExecQuery("Select * From Win32_OperatingSystem")
    For Each os In OsSet
        msg = msg & os.Caption
    Next os
    Set Service = Nothing
    Set OsSet = Nothing
    Set Locator = Nothing
    
    'OSバージョン名のみにする
    msg = Replace(msg, "Microsoft Windows ", "")
    
    GetWinVer = msg
End Function

'**********************************************
' Windowsの32bit/64bitを判定する関数
'**********************************************
Function GetWinBitNum()

    Dim Locator, Service, OsSet, os, msg As String
    Set Locator = CreateObject("WbemScripting.SWbemLocator")
    Set Service = Locator.ConnectServer
    Set OsSet = Service.ExecQuery("Select * From Win32_OperatingSystem")
    For Each os In OsSet
        res = CStr(os.OSArchitecture)
    Next os
    Set Service = Nothing
    Set OsSet = Nothing
    Set Locator = Nothing
    
    res = Replace(res, " ビット", "")
    
    GetWinBitNum = res
    
End Function


'*****************************************
' CrescentEveで開く EVE_EXEC()
'*****************************************
Sub EVE_EXEC()
    Dim myID As Double 'アプリケーションID
    Dim strURL As String 'URL
    'アクティブセルから文字列を抽出
    If cellRangeCount > 1 Then
        strURL = cellValueMerge("\")
    Else
        strURL = ActiveCell.Value
    End If

    '正規判定
    'ＵＲＬであるかどうか
    If DoRegExp("^(http://|https://).+", strURL) = True Then
        MsgBox "URLを直接CrescentEveでは開けません！"
        Exit Sub
    'ファイルパスであるかどうか
    ElseIf DoRegExp("^[a-zA-Z]:\\", strURL) = True Then
        'パスの末尾がHTML関係のファイル拡張子であるかどうか
        If DoRegExp("\.(htm|html|css|php|cgi)$", strURL) = True Then
            strURL = strURL
        Else
            MsgBox "不正なファイルパスが選択されています。選択しなおしてください。"
            Exit Sub
        End If
    Else
        MsgBox "不正なファイルパスが選択されています。選択しなおしてください。"
        Exit Sub
    End If

    'shell関数でCrescentEveを起動する
    On Error Resume Next
    myID = Shell("C:\Program Files\Crescent Eve\Eve.exe " & strURL, vbNormalNoFocus)
End Sub

'*****************************************
' ディレクトリパスを自動で開くAUTO_MYCOM()
'*****************************************
Sub AUTO_MYCOM()
    Dim myID As Double 'アプリケーションID
    Dim strURL As String 'URL
    'アクティブセルから文字列を抽出
    If cellRangeCount > 1 Then
        strURL = cellValueMerge("\")
    Else
        strURL = ActiveCell.Value
    End If

    '正規判定
    'ＵＲＬであるかどうか
    If DoRegExp("^(http://|https://).+", strURL) = True Then
        MsgBox "URLをExplorer.exeでは開けません！"
        Exit Sub
    'ファイルパスであるかどうか
    ElseIf DoRegExp("^[a-zA-Z]:\\", strURL) = True Then
        'パスの末尾がHTML関係のファイル拡張子であるかどうか
        If DoRegExp("\.(htm|html|css|php|cgi)$", strURL) = False Then
            strURL = strURL
        Else
            MsgBox "ディレクトリ名の後ろにファイル名が付いてます。不正な処理です。"
            Exit Sub
        End If
    Else
        MsgBox "不正なファイルパスが選択されています。選択しなおしてください。"
        Exit Sub
    End If

    'shell関数でマイコンピュータ(Explorer.exe)を起動
    On Error Resume Next
    myID = Shell("C:\WINDOWS\explorer.exe " & strURL, vbNormalNoFocus)
End Sub

'*****************************************
' クイックオートフィル(関数を含めない)
'*****************************************
Sub QUICK_FILL_OLD()

Dim RowLimit, colLimit As Integer
Dim i, j As Integer
Dim copyStr As String

copyStr = Selection.Cells(1, 1).Value

RowLimit = Selection.Rows.Count
colLimit = Selection.Columns.Count

For i = 1 To RowLimit
    For j = 1 To colLimit
        Selection.Cells(i, j) = copyStr
    Next
Next

End Sub

'*****************************************
' クイックオートフィル(関数も含める)
'*****************************************
Sub QUICK_FILL()

Dim RowLimit, colLimit As Integer
Dim i, j As Integer
Dim copyStr As String

copyStr = Selection.Cells(1, 1).FormulaR1C1

RowLimit = Selection.Rows.Count
colLimit = Selection.Columns.Count

For i = 1 To RowLimit
    For j = 1 To colLimit
        Selection.Cells(i, j).FormulaR1C1 = copyStr
    Next
Next

End Sub

'*****************************************
' セルを結合／分割するマクロ
'*****************************************
Sub CELL_MERGING()

Dim XCell, YCell As Integer
Dim i As Integer
Dim copyStr As Variant

Dim MergeRange As Range

XCell = Selection.Rows.Count
YCell = Selection.Columns.Count

Set MergeRange = Selection

If XCell > 1 Or YCell > 1 Then
    If MergeRange.MergeCells Then
        MergeRange.UnMerge
        'セルの結合を戻しオートフィルをかける
        copyStr = MergeRange.Cells(1, 1).Value
        For i = 1 To XCell
            MergeRange.Cells(i, 1).FormulaR1C1 = copyStr
        Next i
    Else
        MergeRange.Merge
    End If
Else
    MsgBox "一つのセルしか選択されていません！"
End If

End Sub


'*****************************************
' 選択範囲のセルの行数を表示するマクロ
'*****************************************
Sub COUNT_RANGE_ROW()
Dim y As Integer

y = Selection.Rows.Count
MsgBox "選択範囲のデータ件数は" & y & "です。"

End Sub

'*****************************************
' 現在のセル値をn倍する
'*****************************************
Sub KakeByInput()
Dim v As Double
Dim s As Double
Dim i As Integer

v = ActiveCell.Value
s = InputBox("倍数を入力すべし。", "KakeByInput")
If IsNull(s) Then Exit Sub

v = v * s
ActiveCell.Value = v

End Sub

'**********************************************************************
' BFSのｴﾗｰﾘｽﾄで黄色にした行のﾃﾞｰﾀをｸﾘｯｸﾎﾞｰﾄﾞに転送するﾏｸﾛ
'**********************************************************************
Sub BFS_ERR_ROW_GET()
    Dim Obj As Range '選択範囲
    Dim i, j, ix As Integer
    Dim rMax, cMax As Integer
    Dim allText As String
    Range(Cells(5, 1), Cells(Range("C65536").End(xlUp).row, 8)).Select
    Set Obj = Selection
    rMax = Obj.Rows.Count
    allText = ""
    For i = 1 To rMax
        If Obj.Cells(i, 1).Interior.ColorIndex = 6 Then
                rowData = _
                Obj.Cells(i, 1).Value & vbTab & _
                Obj.Cells(i, 2).Value & vbTab & _
                Obj.Cells(i, 3).Value & vbTab & _
                Obj.Cells(i, 4).Value & vbTab & _
                Obj.Cells(i, 5).Value & vbTab & _
                Obj.Cells(i, 6).Value & vbTab & _
                Obj.Cells(i, 7).Value & vbTab & _
                Obj.Cells(i, 8).Value
                Debug.Print rowData
                allText = allText & rowData & vbCrLf
         End If
    Next i
    '全文をｸﾘｯﾌﾟﾎﾞｰﾄﾞへ転送
    Call DataSendClipBoard(allText)
End Sub


'*************************************************************
'ﾜｰｸﾌﾞｯｸ中の全ｼｰﾄのﾃﾞｰﾀをｺﾋﾟｰしてｸﾘｯｸﾎﾞｰﾄﾞに転送するﾏｸﾛ
'*************************************************************
Sub ALL_SHEETS_TABLE_COPY_MAIN()

    Dim ws As Worksheet
    Dim SheetName As String
    'ForEach文によりﾜｰｸﾌﾞｯｸ中の全ｼｰﾄ名を取得する
    'wsに各ｼｰﾄ名が入る
    For Each ws In Worksheets
        SheetName = ws.Name
        
        txtData = txtData & vbCrLf & SheetName & vbCrLf & ActiveSheetTableCopy(SheetName) & vbCrLf
    Next
    'Debug.Print txtData
    'ｸﾘｯﾌﾟﾎﾞｰﾄﾞへ転送する
    Call DataSendClipBoard(txtData)
End Sub

'*****************
'クリップボード転送
'******************
Function DataSendClipBoard(ByVal str As String)
    Dim buf As String
    Dim CB As New DataObject
    buf = str
    With CB
        .SetText buf
        .PutInClipboard
    End With
End Function

Function ActiveSheetTableCopy(ByVal SheetName As String)
    Dim txtData As Variant
    Dim y1, y2, x1, x2 As Long
    Sheets(SheetName).Activate
    Range("A2").CurrentRegion.Select
    Dim sa As Range
    Set sa = Selection
    y1 = sa.row
    y2 = sa.Rows(sa.Rows.Count).row
    x1 = sa.Column
    x2 = sa.Columns(sa.Columns.Count).Column
    Dim x, y As Long
    For y = y1 To y2
        For x = x1 To x2
            txtData = txtData & Cells(y, x).Value & vbTab
        Next x
        txtData = txtData & vbCrLf
    Next y
    ActiveSheetTableCopy = txtData
End Function


'***********************************************************
' JISユーティリティ
'***********************************************************

Sub JisDiagRun()
    JisDiag01.Show
End Sub

'**********************************************************
' プライベート右クリックコマンド
'**********************************************************
Sub R_Copy()
    SendKeys "^C"
End Sub

Sub R_Paste()
    SendKeys "^V"
End Sub

Sub R_SelAll()
    SendKeys "^A"
End Sub


'************************************************************
'  ＵＲＬが入力されているセルにハイパーリンク設定
'  複数セルも同時に設定
'************************************************************
Sub SetLink()
    Dim sa As Range
    Dim x1, x2, y1, y2 As Integer
    Dim i, j As Integer
    Dim cdata, ldata As Variant
    
    Set sa = Selection
    y1 = sa.row
    y2 = sa.Rows(sa.Rows.Count).row
    x1 = sa.Column
    x2 = sa.Columns(sa.Columns.Count).Column
    
    j = x1
    
    For i = y1 To y2
        cdata = Trim(ActiveSheet.Cells(i, j).Value)
        If Len(cdata) > 0 Then
            ActiveSheet.Hyperlinks.Add Anchor:=ActiveSheet.Cells(i, j), Address:=ActiveSheet.Cells(i, j).Value
        End If
    Next i
    
End Sub


'************************************************************
'  特定の文字列が入ったセルの数を数える
'************************************************************
Sub DataCellCount()
    Dim cv As Variant
    Dim sc As Range
    Dim x1, x2, j, cnt As Integer
    Dim keywd As Variant
    
    Set sc = Selection
    x1 = sc.row
    x2 = sc.Rows(sc.Rows.Count).row
    j = sc.Column
    cnt = 0
    
    keywd = JisDiag01.KeyText.Value
    
    If keywd = "" Then
        MsgBox "キーワードが入力されていません"
        JisDiag01.KeyText.SetFocus
    Else
        For i = x1 To x2
            cv = ActiveSheet.Cells(i, j).Value
            If cv = keywd Then
                cnt = cnt + 1
            End If
        Next i

        JisDiag01.TextBox1.Value = "[" & keywd & "] の検索結果： " & cnt
    End If
    
End Sub


'************************************************************
'  開始と終了セルを取得する
'************************************************************
Sub GetFirstAndLastMain()
    Dim fc, lc As Variant
    Dim sc As Range
    Dim x1, x2, j, cnt As Integer

    Set sc = Selection
    x1 = sc.row
    x2 = sc.Rows(sc.Rows.Count).row
    j = sc.Column
    
    fc = ActiveSheet.Cells(x1, j).Value
    lc = ActiveSheet.Cells(x2, j).Value
    
    JisDiag01.TextBox1.Value = fc & " " & lc
    
End Sub


'************************************************************
'  セル値を取得する
'************************************************************
Sub GetCellDataMain()
    Dim fc As Variant
    Dim sc As Range
    Dim x1, x2, j, cnt As Integer

    Set sc = Selection
    x1 = sc.row
    x2 = sc.Rows(sc.Rows.Count).row
    j = sc.Column
    
    fc = ActiveSheet.Cells(x1, j).Value
    
    JisDiag01.TextBox2.Value = fc
    
End Sub

'************************************************************
'  判定箇所レポートの作成
'************************************************************
Sub HanteiReport()
    Dim fc As Variant
    Dim sc As Range
    Dim x1, x2, y1, y2 As Integer
    Dim i, j As Integer
    Dim allCnt, compCnt, uncompCnt As Integer
    

    Set sc = Selection
    y1 = sc.row
    y2 = sc.Rows(sc.Rows.Count).row
    x1 = sc.Column
    x2 = sc.Columns(sc.Columns.Count).Column
    
    allCnt = 0
    compCnt = 0
    uncompCnt = 0
    
    For i = y1 To y2
        For j = x1 To x2
            If ActiveSheet.Cells(i, j).Value <> "" Then
                allCnt = allCnt + 1
            End If
            If ActiveSheet.Cells(i, j).Value <> "－" Then
                compCnt = compCnt + 1
            End If
            If ActiveSheet.Cells(i, j).Value = "－" Then
                uncompCnt = uncompCnt + 1
            End If
        Next j
    Next i
    Dim pc As Single
    pc = compCnt / allCnt
    pc = pc * 100
    fc = "全診断箇所数:" & allCnt & " 完了数:" & compCnt & " 未完了数:" & uncompCnt & " 進捗率:" & pc
    
    JisDiag01.TextBox1.Value = fc
    
End Sub

'************************************************************
' 修正マニュアルひながた生成
'************************************************************
Sub createHinagata()
    Dim fc As Variant
    Dim sc As Range
    Dim x, y As Integer
    Dim Cmt, Dsc, Jis, Tech, Src As Variant
    Dim str As String
    
    Set sc = Selection
    x = sc.Column
    y = sc.row
    
    Dsc = ActiveSheet.Cells(y, x).Value
    Cmt = ActiveSheet.Cells(y, x + 1).Value
    Jis = ActiveSheet.Cells(y, x + 2).Value
    Tech = ActiveSheet.Cells(y, x + 3).Value
    Src = ActiveSheet.Cells(y, x + 4).Value
    str = "達成基準　" & Jis & vbCrLf & vbCrLf
    str = str & "実装番号　" & Tech & vbCrLf & vbCrLf
    str = str & "対象ソースコードと対応箇所" & vbCrLf
    str = str & Dsc & vbCrLf & vbCrLf
    str = str & "コメントと意味" & vbCrLf
    str = str & Cmt & vbCrLf & vbCrLf
    str = str & "修正ソースコードについて" & vbCrLf
    str = str & Src & vbCrLf

    JisDiag01.TextBox1.Value = str
    
End Sub



'************************************************************
'  ガイドラインハッシュ生成
'************************************************************
Sub guidHashCreate()
    Dim firstRow, tmpRow As Variant
    Dim resultText As String
    
    Dim sc As Range
    Dim i, x1, x2, j1, j0 As Integer

    Set sc = Selection
    x1 = sc.row
    x2 = sc.Rows(sc.Rows.Count).row
    j1 = sc.Column
    j0 = j1 - 1
    
    firstRow = ActiveSheet.Cells(x1, j0).Value
    resultText = "'" & firstRow & "'" & ": '"
    
    For i = x1 To x2
        tmpRow = ActiveSheet.Cells(i, j1).Value
        If i = x2 Then
            resultText = resultText & tmpRow
        Else
            resultText = resultText & tmpRow & ","
        End If
        
    Next i
    
    resultText = resultText & "',"
    

   TmpDiag.Result.Value = resultText
    
End Sub

'*********************************************************
' 実装番号解説生成
'*********************************************************
Sub techSummaryCreate()
    Dim tmpRow As Variant
    Dim resultText As String
    Dim sc As Range
    Dim i, x1, x2, y1, y2, y3 As Integer
    
    Set sc = Selection
    
    x1 = sc.row
    x2 = sc.Rows(sc.Rows.Count).row
    y3 = sc.Column
    y1 = y3 - 2
    y2 = y3 - 1
    
    For i = x1 To x2
        resultText = resultText & "'" & ActiveSheet.Cells(i, y1).Value & "': "
        resultText = resultText & "'" & ActiveSheet.Cells(i, y2).Value & ","
        resultText = resultText & ActiveSheet.Cells(i, y3).Value & "'," & Chr(13) & Chr(10)
    Next i
    
   TmpDiag.Result.Value = resultText
    
    
End Sub

'******************************************
' 選択範囲をUTF-8テキストファイルに出力
'******************************************
Sub createTextfileForUtf()

    Dim i, x1, x2, y1 As Integer
    Dim sc As Range
    Dim filePathStr As String
    Dim tmpRow As Variant

    Dim sr As Object
    Set sr = CreateObject("ADODB.Stream")
    
    sr.Mode = 3
    sr.Type = 2
    sr.Charset = "UTF-8"
    sr.Open
    
    Set sc = Selection
    x1 = sc.row
    x2 = sc.Rows(sc.Rows.Count).row
    y1 = sc.Column
    
    For i = x1 To x2
        tmpRow = ActiveSheet.Cells(i, y1).Value
        sr.WriteText tmpRow, adWriteLine
    Next i
    
    'ダイアログボックスの変数をセット
    FileType = "TXT ﾌｧｲﾙ (*.txt),*.txt"
    Prompt = "保存するファイルの名前を付けてください"
    
    '保存するファイルのパスを取得
    filePathStr = getMyFilePath(FileType, Prompt)
    
    Dim byteData() As Byte
    sr.Position = 0
    sr.Type = adTypeBinary
    sr.Position = 3
    byteData = sr.Read
    sr.Close
    sr.Open
    sr.Write byteData
    
    sr.SaveToFile filePathStr, 2
    sr.Close
    Set sr = Nothing

End Sub



'**************************************************
' 選択範囲を簡易CSVファイルに保存
'**************************************************
Sub createEasyCSVFile()
    Dim i, x1, x2, y1, y2 As Integer
    Dim sc As Range
    Dim filePathStr As String
    Dim tmpRow As Variant
    
    Dim sr As Object
    Set sr = CreateObject("ADODB.Stream")
    
    sr.Mode = 3
    sr.Type = 2
    sr.Charset = "Shift_JIS"
    sr.Open
    
    Set sc = Selection
    x1 = sc.row
    x2 = sc.Rows(sc.Rows.Count).row
    y1 = sc.Column
    y2 = sc.Columns(sc.Columns.Count).Column
    
    For i = x1 To x2
        tmpRow = Null
        For j = y1 To y2
            If j = y2 Then
                tmpRow = tmpRow & ActiveSheet.Cells(i, j).Value
            Else
                tmpRow = tmpRow & ActiveSheet.Cells(i, j).Value & ","
            End If
        Next j

        sr.WriteText tmpRow, adWriteLine
    Next i
    
    FileType = "CSV ﾌｧｲﾙ(*.csv),*.csv"
    Prompt = "保存するﾌｧｲﾙの名前を付けてください"
    filePathStr = getMyFilePath(FileType, Prompt)
    
    sr.SaveToFile filePathStr, 2
    sr.Close
    Set sr = Nothing
    
End Sub

'**************************************************
'保存ダイアログ関数
'**************************************************
Function getMyFilePath(FileType, Prompt) As Variant
  getMyFilePath = Application.GetSaveAsFilename _
                                  (ActiveSheet.Name, FileType, , Prompt)
End Function

'**************************************************
' 選択範囲から簡易CSVデータを作成
'**************************************************
Sub createEasyCSVData()
    Dim i, x1, x2, y1, y2 As Integer
    Dim sc As Range
    Dim tmpRow, allRow As Variant

    Set sc = Selection
    x1 = sc.row
    x2 = sc.Rows(sc.Rows.Count).row
    y1 = sc.Column
    y2 = sc.Columns(sc.Columns.Count).Column
    
    For i = x1 To x2
        tmpRow = Null
        For j = y1 To y2
            If j = y2 Then
                tmpRow = tmpRow & ActiveSheet.Cells(i, j).Value & vbCrLf
            Else
                tmpRow = tmpRow & ActiveSheet.Cells(i, j).Value & ","
            End If
        Next j
        allRow = allRow & tmpRow
    Next i
    
    JisDiag01.TextBox1.Value = allRow
    
End Sub



'***********************************************
'現在のレポート行のURLを取得する
'***********************************************
Sub GetThisRowURL()
    Dim cc As Range
    Dim col, row, new_row As Integer
    Dim cd As Variant
    Dim urlText As Variant
    
    Set cc = Selection
    row = cc.row
    col = cc.Column
    If col > 1 Then
        MsgBox "１列目にカーソルがありません"
        Exit Sub
    End If

    For new_row = row To 4 Step -1
        cd = ActiveSheet.Cells(new_row, col).Value
        If cd <> "" Then
            urlText = cd
            Exit For
        End If
    Next new_row
    JisDiag01.TextBox1.Value = urlText
End Sub


'**********************************************
'Cyberfoxで開く
'**********************************************
Function CYBERFOX_EXEC(strURL As String)
    Dim myID As Double 'アプリケーションID
    Dim regEx As Object, Matches As Object, Match As Object
    
    '自作関数で修正指示書URL表記にマッチするか判定
    If DoRegExp("\[[a-zA-Z0-9]+\].+", strURL) = False Then
        MsgBox "URLのデータが選ばれていません"
        Exit Function
    End If
    
    '正規表現オブジェクトを生成・設定
    Set regEx = CreateObject("VBScript.RegExp")
    With regEx
        .Pattern = "(\[[a-zA-Z0-9]+\])(.+)"
        .IgnoreCase = False
        .Global = True
    End With
    
    'Matchオブジェクトを取得
    On Error Resume Next
    Set Matches = regEx.Execute(strURL)
    If Matches.Count = 0 Then
        MsgBox "エラーが発生しました。"
        Exit Function
    End If
    
    For Each Match In Matches
        strURL = Match.SubMatches(1)
    Next Match

    
    'shell関数でFirefoxを起動する
    On Error Resume Next
    '32bit Windowsの場合
    If GetWinBitNum = "32" Then
        myID = Shell("C:\Program Files\Cyberfox\Cyberfox.exe -new-tab " & strURL, vbNormalNoFocus)
    '64bit Windowsの場合
    Else
        myID = Shell("C:\Program Files(x86)\Cyberfox\Cyberfox.exe -new-tab " & strURL, vbNormalNoFocus)
    End If
End Function

'**********************************************
'セルのURLから
'**********************************************
Sub CYBERFOX_EXEC_CELL()
    Dim sc As Range
    Set sc = Selection
    strURL = ActiveSheet.Cells(sc.row, sc.Column).Value
    CYBERFOX_EXEC (strURL)
End Sub

'**********************************************
'セルのURLから
'**********************************************
Sub CYBERFOX_EXEC_FORM()
    strURL = JisDiag01.TextBox1.Value
    CYBERFOX_EXEC (strURL)
End Sub



'**********************************************
' ページタイトル取得
'**********************************************
Sub insertPageTitle()
    Dim sa As Range
    Dim x1, x2, y, i, j As Integer
    Dim cv As String
    Dim pt As String
    
    Set sa = Selection
    x1 = sa.row
    x2 = sa.Rows(sa.Rows.Count).row
    y = sa.Column
    j = y
    For i = x1 To x2
        cv = ActiveSheet.Cells(i, j).Value & ""
        If DoRegExp("(http:|https:).+", cv) = True Then
            pt = getPageTitle2(cv)
            ActiveSheet.Cells(i, j + 1).Value = pt
        End If
    Next i
    
End Sub

Function getPageTitle2(url)
    Set ie = CreateObject("InternetExplorer.Application")
    ie.Navigate url
    ie.Visible = False
    ieSuspend ie
    pt = ie.document.getElementsByTagName("title")(0).innerText
    ie.Quit
    Set ie = Nothing
    getPageTitle2 = pt
End Function

Function ieSuspend(ie)
    Do While ie.Busy = True Or ie.readystate <> 4
        DoEvents
    Loop
    Sleep 100
End Function


'**********************************************
' WC3バリデートをFirefoxで実行
'**********************************************
Sub W3C_FOX_EXEC()
   Dim myID As Double 'アプリケーションID
    Dim strURL As String 'URL
    'アクティブセルから文字列を抽出
    If cellRangeCount > 1 Then
        strURL = cellValueMerge("\")
    Else
            strURL = ActiveCell.Value
    End If

    '正規判定
    'ＵＲＬであるかどうか
    If DoRegExp("^(http://|https://).+", strURL) = True Then
        strURL = Replace(strURL, "\", "/")
    'ファイルパスであるかどうか
    ElseIf DoRegExp("^[a-zA-Z]:\\", strURL) = True Then
        'パスの末尾がHTML関係のファイル拡張子であるかどうか
        If DoRegExp("\.(htm|html|css|php|cgi)$", strURL) = True Then
            strURL = strURL
        Else
            MsgBox "不正なファイルパスが選択されています。選択しなおしてください。"
            Exit Sub
        End If
    ElseIf Not GetCellHref() = "" Then
            strURL = GetCellHref()
    Else
        MsgBox "不正なファイルパスが選択されています。選択しなおしてください。"
        Exit Sub
    End If
    
    'Ｗ３Ｃをダイレクトに参照するＵＲＬを生成
    Dim w3cURL As String
    w3cURL = ""
    w3cURL = "http://validator.w3.org/check?uri=" & _
    strURL & "&charset=%28detect+automatically%29&doctype=Inline&ss=1&group=1&verbose=1&" & _
    "&user-agent=W3C_Validator%2F1.3+http%3A%2F%2Fvalidator.w3.org%2Fservices"
    
    
    'http://validator.w3.org/check?uri=http%3A%2F%2Fjci-tn.jp%2F&charset=%28detect+automatically%29&doctype=Inline&ss=1&group=1&verbose=1&user-agent=W3C_Validator%2F1.3+http%3A%2F%2Fvalidator.w3.org%2Fservices
    

    'shell関数でFirefoxを起動する
    On Error Resume Next
    '32bit Windowsの場合
    If GetWinBitNum = "32" Then
        myID = Shell("C:\Program Files\Mozilla Firefox\firefox.exe -new-tab " & w3cURL, vbNormalNoFocus)
    '64bit Windowsの場合
    Else
        myID = Shell("C:\Program Files(x86)\Mozilla Firefox\firefox.exe -new-tab " & w3cURL, vbNormalNoFocus)
    End If
End Sub


'*******************************************************
' 確認作業割当て氏名入力
'*******************************************************
Sub CheckerAssign()
    Dim sa As Range
    Dim x0, x, y0, y, i, j As Integer
    Dim cdata As Variant
    Dim tdata As Variant
    Dim ccommt As Boolean
    ccommt = True
    tdata = JisDiag01.KeyText.Value
    If tdata = "" Then
        MsgBox "割当担当を入力してください！"
        Exit Sub
    End If
    Set sa = Selection
    y0 = sa.row
    x0 = sa.Column
    y = sa.Rows(sa.Rows.Count).row
    x = sa.Columns(sa.Columns.Count).Column
    For i = y0 To y
        For j = x0 To x
            cdata = ActiveSheet.Cells(i, j).Value
            If is_human_name(cdata) = True Then
                If ccommt = True Then
                    ActiveSheet.Cells(i, j).AddComment ("検査担当: " & cdata)
                End If
                ActiveSheet.Cells(i, j).Value = tdata
            End If
        Next j
    Next i
End Sub

Function is_human_name(ByRef str As Variant)
    If str Like "◎" Or str Like "○" Or str Like "△" Or str Like "－" Then
        is_human_name = False
    Else
        is_human_name = True
    End If
End Function

'*******************************************************
' 確認作業割当て解除
'*******************************************************
Sub CheckerDelete()
    Dim sa As Range
    Dim x0, x, y0, y, i, j As Integer
    Dim cdata As Variant
    Dim tdata As Variant
    Dim cmmdata As Variant

    
    Set sa = Selection
    y0 = sa.row
    x0 = sa.Column
    y = sa.Rows(sa.Rows.Count).row
    x = sa.Columns(sa.Columns.Count).Column
    For i = y0 To y
        For j = x0 To x
            cdata = ActiveSheet.Cells(i, j).Value
            cmmdata = ActiveSheet.Cells(i, j).NoteText
            If is_human_name(cdata) = True And cmmdata <> "" Then
                tdata = get_surverer(cmmdata)
                ActiveSheet.Cells(i, j).Value = tdata
            End If
        Next j
    Next i
    sa.ClearComments
End Sub

Function get_surverer(ByRef str As Variant)
    Dim ps, pe As Integer
    ps = InStr(str, " ")
    get_surverer = Mid(str, ps + 1)
End Function

Sub MyClearComments()
    Dim sa As Range
    Set sa = Selection
    sa.ClearComments
End Sub



'*******************************************
' URL比較
'*******************************************
Sub diff_url()
    Dim sa As Range
    Dim x0, x1, y0, y1, i, j As Integer
    Dim leftCel, rightCel As Variant
    
    Set sa = Selection
    x0 = sa.row
    x1 = sa.Rows(sa.Rows.Count).row
    y0 = sa.Column
    y1 = sa.Columns(sa.Columns.Count).Column
    For i = x0 To x1
        leftCel = ActiveSheet.Cells(i, y0).Value
        rightCel = ActiveSheet.Cells(i, y1).Value
        If leftCel <> rightCel Then
            ActiveSheet.Cells(i, y0).Interior.ColorIndex = 3
        End If
    Next i
    
    
End Sub

'*******************************************
' 同一URL検索
'*******************************************
Sub same_url()
    Dim sa As Range
    Dim x0, x1, y0, y1, i, j As Integer
    Dim keyCel, srchCel As Variant
    
    Set sa = Selection
    x0 = sa.row
    x1 = sa.Rows(sa.Rows.Count).row
    y0 = sa.Column
    For i = x0 To x1
        keyCel = ActiveSheet.Cells(i, y0).Value
        For j = x0 To x1
            srchCel = ActiveSheet.Cells(j, y0 + 1).Value
            If keyCel = srchCel Then
                ActiveSheet.Cells(i, y0).Interior.ColorIndex = 4
                ActiveSheet.Cells(j, y0 + 1).Interior.ColorIndex = 4
            End If
        Next j
    Next i
End Sub

'*******************************************
'指定したURLに色を付ける
'*******************************************
Sub url_mark_color()
    Dim sa As Range
    Dim x0, x1, y0, y1, i, j As Integer
    Dim celVal, arrVal As Variant
    Dim frmText, urlList As Variant
    
    Set sa = Selection
    x0 = sa.row
    x1 = sa.Rows(sa.Rows.Count).row
    y0 = sa.Column
    frmText = JisDiag01.TextBox1.Value
    urlList = Split(frmText, vbCrLf)
    
    For i = x0 To x1
        celVal = ActiveSheet.Cells(i, y0).Value
        For j = 0 To UBound(urlList)
            arrVal = urlList(j)
            If arrVal = celVal Then
                ActiveSheet.Cells(i, y0).Interior.ColorIndex = 3
            End If
        Next j
    Next i
    
End Sub

'*******************************************
' URL並び換え
'*******************************************
Sub same_url_relocate()
    Dim sa As Range
    Dim x0, x1, y0, y1, i, j As Integer
    Dim keyCel, srchCel, pageID As Variant
    
    Set sa = Selection
    x0 = sa.row
    x1 = sa.Rows(sa.Rows.Count).row
    y0 = sa.Column
    For i = x0 To x1
        keyCel = ActiveSheet.Cells(i, y0).Value
        For j = x0 To x1
            srchCel = ActiveSheet.Cells(j, y0 + 2).Value
            pageID = ActiveSheet.Cells(j, y0 + 1).Value
            If keyCel = srchCel Then
                ActiveSheet.Cells(i, y0 + 3).Value = pageID
                ActiveSheet.Cells(i, y0 + 4).Value = srchCel
            End If
        Next j
    Next i
End Sub

'*************************************
' カラーコード取得
'*************************************
Sub get_cell_color_num()
    Dim sa As Range
    Set sa = Selection
    Dim x, y As Integer
    Dim ColorStr As String
    x = sa.row
    y = sa.Column
    ColorStr = ActiveSheet.Cells(x, y).Interior.ColorIndex
    JisDiag01.TextBox2.Value = ColorStr
End Sub

'*************************************
' 特定色セルの値をリストを生成
'*************************************
Sub get_same_color_cell_val_list()
    Dim sa As Range
    Dim r0, r1, c, i, j As Integer
    Dim cc As Integer
    Dim ret As String
    
    
    cc = CInt(JisDiag01.TextBox2.Value)
    
    Set sa = Selection
    r0 = sa.row
    r1 = sa.Rows(sa.Rows.Count).row
    c = sa.Column
    
    For i = r0 To r1
        Dim crCC As Integer
        Dim crVAL As Variant
        
        crCC = ActiveSheet.Cells(i, c).Interior.ColorIndex
        crVAL = ActiveSheet.Cells(i, c).Value
        
        If cc = crCC Then
            If i = r1 Then
                ret = ret & crVAL
            Else
                ret = ret & crVAL & vbCrLf
            End If
        End If
    Next i
    
    JisDiag01.TextBox1.Value = ret
    
End Sub

'**************************************************
'値リストに存在するデータと一致するセルに色を付ける
'**************************************************
Sub list_datas_match_colored()
    
    Dim tb1, tb2, tArr As Variant
    Dim sa As Range
    Dim r1, r2, c1, i, j As Integer
    
    tb1 = JisDiag01.TextBox1.Value
    tb2 = JisDiag01.TextBox2.Value
    If tb2 = "" Then
        tb2 = 6
    End If
    tArr = Split(tb1, vbCrLf)
    Set sa = Selection
    r1 = sa.row
    r2 = sa.Rows(sa.Rows.Count).row
    c1 = sa.Column
    
    For i = 0 To UBound(tArr)
        Dim line As Variant
        line = tArr(i)
        For j = r1 To r2
            Dim cdata As Variant
            cdata = ActiveSheet.Cells(j, c1).Value
            If line = cdata Then
                ActiveSheet.Cells(j, c1).Interior.ColorIndex = tb2
            End If
        Next j
    Next i
    
End Sub

Sub wintest()
MsgBox Application.OperatingSystem
End Sub


Sub setFlag()
    Dim sa As Range
    Set sa = Selection
    Dim y, x, yn, xn As Long
    y = sa.row
    yn = sa.Rows(sa.Rows.Count).row
    x = sa.Column
    xn = sa.Columns(sa.Columns.Count).Column
    Dim i, j As Long
    Dim c1, c2, sv As Variant
    
    For i = y To yn
        c1 = ActiveSheet.Cells(i, 1).Value
        Dim cnt As Integer
        cnt = InStr(c1, "テキスト")
        If cnt < 1 Then
             ActiveSheet.Cells(i, 3).Value = "通常"
        Else
            ActiveSheet.Cells(i, 3).Value = "テキスト"
        End If
    Next i
    
End Sub

'***********************************
' 選択範囲で乱数列挙
'***********************************
Sub RandomForRange()
    Dim sa As Range
    Set sa = Selection
    Dim cnt, y, x, yn, xn As Integer
    y = sa.row
    yn = sa.Rows(sa.Rows.Count).row
    x = sa.Column
    xn = sa.Columns(sa.Columns.Count).Column
    cnt = sa.Rows.Count
    
    Dim i, j As Integer
    Dim c1, c2, sv As Variant

    For i = y To yn
        Randomize
        ActiveSheet.Cells(i, x).Value = Int(cnt * Rnd + 1)
    Next i
    
    
End Sub


'***********************************
' 選択範囲のURLのセルにハイパーリンクを設定する
'***********************************
Sub SetUrlCellHyperLink()
    Dim sa As Range
    Set sa = Selection
    Dim x, y, yn, i As Long
    
    y = sa.row
    yn = sa.Rows(sa.Rows.Count).row
    x = sa.Column
    
    For i = y To yn
        
        With ActiveSheet.Hyperlinks
            .Add Anchor:=Cells(i, x), Address:=Cells(i, x).Value
        End With

    Next i
    
End Sub



