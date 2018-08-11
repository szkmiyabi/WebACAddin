VERSION 5.00
Begin {C62A69F0-16DC-11CE-9E98-00AA00574A4F} JisDiag01 
   Caption         =   "JISX8341-3 ツール"
   ClientHeight    =   3420
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   7185
   OleObjectBlob   =   "JisDiag01.frx":0000
   ShowModal       =   0   'False
   StartUpPosition =   1  'オーナー フォームの中央
End
Attribute VB_Name = "JisDiag01"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim rightMenu As Variant

Private Sub AssignBtn_Click()
    CheckerAssign
End Sub

Private Sub AssignDelBtn_Click()
    CheckerDelete
End Sub

Private Sub AutoLinkBtn_Click()
    SetLink
End Sub



Private Sub BrowseCellBtn_Click()
    CYBERFOX_EXEC_CELL
End Sub

Private Sub BrowseFormBtn_Click()
    CYBERFOX_EXEC_FORM
End Sub

Private Sub CellCntBtn_Click()
    DataCellCount
End Sub

Private Sub ClearBtn_Click()
    Me.TextBox1 = ""
End Sub

Private Sub CommDelBtn_Click()
    MyClearComments
End Sub

Private Sub CrtCsvBtn_Click()
    Dim flag As Variant
    flag = Me.FileOutFlag.Value
    If flag = True Then
        createEasyCSVFile
    Else
        createEasyCSVData
    End If
End Sub

Private Sub CrtUrlBtn_Click()
    createTextfileForUtf
End Sub

Private Sub ExtAutoNumBtn_Click()
    CreateExtNum
End Sub

Private Sub GetCellDataBtn_Click()
    GetCellDataMain
End Sub

Private Sub getColorBtn_Click()
    get_cell_color_num
End Sub

Private Sub GetFirstLastBtn_Click()
    GetFirstAndLastMain
End Sub


Private Sub hinagataBtn_Click()
    createHinagata
End Sub

Private Sub HReportBtn_Click()
    HanteiReport
End Sub



Private Sub projText_MouseUp(ByVal Button As Integer, ByVal Shift As Integer, ByVal x As Single, ByVal y As Single)
    If Button = 2 Then rightMenu.ShowPopup
End Sub



Private Sub ListMatchColorBtn_Click()
    list_datas_match_colored
End Sub

Private Sub pageTitleBtn_Click()
    insertPageTitle
End Sub

Private Sub randomOrderBtn_Click()
    RandomForRange
End Sub

Private Sub RowToURLBtn_Click()
    GetThisRowURL
End Sub

Private Sub SetUrlCellHyperLinkBtn_Click()
    SetUrlCellHyperLink
End Sub

Private Sub TextBox1_MouseUp(ByVal Button As Integer, ByVal Shift As Integer, ByVal x As Single, ByVal y As Single)
    If Button = 2 Then rightMenu.ShowPopup
End Sub

Private Sub CmdText_MouseUp(ByVal Button As Integer, ByVal Shift As Integer, ByVal x As Single, ByVal y As Single)
    If Button = 2 Then rightMenu.ShowPopup
End Sub

Private Sub thisColorListBtn_Click()
    get_same_color_cell_val_list
End Sub

Private Sub urlMarkBtn_Click()
    url_mark_color
End Sub

Private Sub UserForm_Initialize()
    
    'コントロールに右クリックメニュー追加
    Set rightMenu = Application.CommandBars.Add(Position:=msoBarPopup, Temporary:=True)
    With rightMenu
        With .Controls.Add
            .Caption = "コピー"
            .OnAction = "R_Copy"
            .FaceId = 19
        End With
        With .Controls.Add
            .Caption = "貼り付け"
            .OnAction = "R_Paste"
            .FaceId = 22
        End With
        With .Controls.Add
            .Caption = "全て選択"
            .OnAction = "R_SelAll"
        End With
    End With
End Sub

Private Sub W3CBtn_Click()
    W3C_FOX_EXEC
End Sub
