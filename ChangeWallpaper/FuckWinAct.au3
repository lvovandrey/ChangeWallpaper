#include <Constants.au3>

;
; AutoIt Version: 3.0
; Language:       English
; Platform:       Win9x/NT
; Author:         Jonathan Bennett (jon at autoitscript dot com)
;
; Script Function:
;   Plays with the calculator.
;
Global $Ico = 'logoR.ico'


If Not @compiled Then
    If FileExists($Ico) Then
	   TraySetIcon($Ico)
    EndIf
 EndIf

Local $iTimeout = 10

; Display a message box with a nested variable in its text.
MsgBox($MB_SYSTEMMODAL, "Закрыватель Активатора Windows", "Для смены фона рабочего стола - зайти в папку C:\\Program Files\FuckWinActivator\wallpapers\ и заменить там файлы jpg. Исходники там же лежат.    Это сообщение пропадет через "  & $iTimeout & " секунд .", $iTimeout)
; Check the user's answer to the prompt (see the help file for MsgBox return values)
; If "No" was clicked (7) then exit the script



; Run the calculator
While True
   WinWait("Активация Windows")
   Sleep(10)
   WinClose("Активация Windows")
   WinWaitClose("Активация Windows")
   Sleep(100)
   Local $iPID = Run("ChangeWalpaper.exe")

   WinWait("Ошибка FuckWinActivator")

WEnd
; Finished!


