   M S B A M L   `   `   `  ����B  >Hangman, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:HangmanHangman  5   	       Hangman.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Hangman     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��400��6)   .��5	      � .+�5   
   � $��20q�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� -   5         ��Name$ txtLogin��5      $��Login��6*   $��18(�67   $
��Bold"�6E   $��Center=�6W   $��0��6t   $y�Visible=�6�   �� 5      -   5        $ txtRegister��5      $��Register��6-   $��18(�6=   $
��Bold"�6K   $��Center=�6]   $��0��6z   $y�	Collapsed=�6�   �� 5      $��	Username:��6   $��1��6(   $��Center=�65   �� 5       -   5         ��Name$ txtUsername��5       $��2��6+   $��5q�68   $��Center=�6C   �� 5#      $��	Password:��6   $��3��6(   $��Center=�65   G� 5$      -   5         G�Name$ pwbPasswordBox1��5$      $��4��63   $��5q�6@   $��Center=�6K   �� 5&      -   5         ��Name$ lblConfirmPw��5&      $��Confirm password:��6*   $��5��6F   $��Center=�6S   $y�	Collapsed=�6n   G� 5'      -   5        $ pwbPasswordBox2��5'      $��6��63   $��5q�6@   $��Center=�6K   $y�	Collapsed=�6f   �� 5+      -   5         ��Name$ btnLogin��5+      $��Login��6'   $��80��67   $��5q�6B   $��7��6M   $��Center=�6Z   $y�Visible=�6�   �� 5,      -   5        $ btnRegister��5,      $��Register��6*   $��80��6=   $��5q�6H   $��7��6S   $��Center=�6`   $y�	Collapsed=�6�   d� 5/      -	   5        $��Switch to Register��5/      $��8��68   $��5q�6E   $��Center=�6P   6m   50      51      52      