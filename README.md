# 🧑‍💼 사내 채팅 시스템 – 회원가입 모듈 (WinForm + C# + MySQL)

## 📌 프로젝트 개요
- 팀 프로젝트로 제작된 사내 채팅 프로그램 중, 회원가입 모듈을 담당
- 사용자 정보 등록, 중복확인, 암호화, 부서/팀 연동, 주소 검색 API까지 포함한 복합 기능 구현

## 🔧 사용 기술
- C#, WinForm
- MySQL (DB 연동)
- WebView2, JavaScript (Daum 주소 검색 API)
- AES + SHA2 기반 비밀번호 암호화

## 🧩 주요 기능
- ID / PW / 이름 / 별명 / 주소 / 부서 / 팀 입력
- ID 중복확인 기능 (DB 조회)
- 프로필 이미지 업로드 (바이너리 처리 및 DB 저장)
- AES + SHA2 기반 비밀번호 암호화 처리
- RESTful API 방식 주소 검색 (WebView2 + 외부 HTML + JS 연동)

## 📷 주요 화면
- 회원가입 폼
- 주소 검색 팝업
- 부서/팀 드롭다운 연동

## ⚠️ 기술적 개선 여지
- ❌ SQL Injection 방어 미흡 → `PreparedStatement` 방식 적용 필요
- ❌ 로직 분리 부족 → UI와 DB 기능 분리하여 `Service`, `Repository` 패턴 적용 가능
- ❌ 예외 처리 미흡 → `try-catch` 문과 사용자 알림 강화 필요
- ❌ 하드코딩된 HTML 외부 의존 → REST API 방식으로 대체 가능 시 더 안정적임
