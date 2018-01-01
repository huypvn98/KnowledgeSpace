#!/bin/bash
MAX_DAYS=2227

rm -rf .git
git init
cat  <<EOF > README.md
# Time Traveler

Want to improve your GitHub vanity metrics ?
Run `run.sh`
It will create a commit for every day for the last $MAX_DAYS days.

## Commits for the last $MAX_DAYS

EOF
git add .
git commit --date "$date" -m "$message"

for ((i = MAX_DAYS; i >= 731; i--)); do
    date="$i days ago"
    message="Fake commited $date"
    echo "- Added fake commit $message" >> README.md
    git add .
    git commit --date "$date" -m "$message"
done

git log --oneline | tac

cat <<EOF

# Now push to GitHub with something like...

git remote add origin https://github.com/jmfayard/timetraveler.git
git branch -M main
git push -u origin main
EOF
