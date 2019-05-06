curl -Uri https://gitignore.io/api/visualstudio | Select-Object -ExpandProperty Content > .gitignore
git init
git add .
git commit -m "initial commit"
git remote add origin https://github.com/andrewtheart/SQLBackupAndRestore.git
git pull origin master --allow-unrelated-histories
git merge origin origin/master
git push origin master




git commit -m "further commits"
git push origin master