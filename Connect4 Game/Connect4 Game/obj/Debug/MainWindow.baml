   M S B A M L   `   `   `  ����H  DConnect4 Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Connect4_GameConnect4_Game  5   	       Connect4_Game.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Connect4_Game     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 
ResizeMode$ NoResize=�65   .��5	      �  � RowDefinitions 5
   
   �� 5      $��7* �6   �� 5      $��8* �6   .+�5   
   �� -   5         ��Name$ play_btn��5      $��	Play Game��6#   $
��Left=�67   $��358,124,0,0q�6R   $	��Top=�6g   $��91��6   ���	#FFA63737$��40��6�   � 5   
   $��
0,0,-0.4,0q�6   $��2��6#   .+�5      �� -   5        $ exit_btn��5      $��Exit
��6'   $
��Left=�6@   $��
10,372,0,0q�6[   $	��Top=�6o   $��86��6�    J� RenderTransformOrigin$ 0.467,0.531&�6�   $��23��6�   ���	#FFA637376�   �� 5      $
��Left=�6   $	��100��6/   $��	56,46,0,0q�6<   $	��Top=�6O   $	��100��6g   �� 5      $��10,10,637.6,259q�6   $��Icon.png��6-   $
��Fill=�6?   �� 5      -   5        $ btn_Highscore��5      $��High Scores
��6,   $
��Left=�6L   $��365,215,0,0q�6g   $	��Top=�6|   $��75��6�   6�   �� 5      $��Connect4��6   $
��Left=�6'   $��
365,17,0,0q�6B   $	��Top=�6V   $��22(�6n   5      5      5      