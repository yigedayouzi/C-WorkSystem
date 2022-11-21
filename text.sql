/*
 Navicat Premium Data Transfer

 Source Server         : Log
 Source Server Type    : MySQL
 Source Server Version : 80028
 Source Host           : localhost:3306
 Source Schema         : text

 Target Server Type    : MySQL
 Target Server Version : 80028
 File Encoding         : 65001

 Date: 21/11/2022 16:35:44
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for admin
-- ----------------------------
DROP TABLE IF EXISTS `admin`;
CREATE TABLE `admin`  (
  `username` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `password` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL
) ENGINE = MyISAM AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_unicode_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of admin
-- ----------------------------
INSERT INTO `admin` VALUES ('123', '9594B94A209BD8918E18F9EFA8AB9432');

-- ----------------------------
-- Table structure for campany
-- ----------------------------
DROP TABLE IF EXISTS `campany`;
CREATE TABLE `campany`  (
  `username` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `campany_name` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `status` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  PRIMARY KEY (`username`) USING BTREE
) ENGINE = MyISAM AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_unicode_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of campany
-- ----------------------------
INSERT INTO `campany` VALUES ('123', '9594B94A209BD8918E18F9EFA8AB9432', '123', 'allow');
INSERT INTO `campany` VALUES ('阿狸巴巴', '9594B94A209BD8918E18F9EFA8AB9432', '阿狸巴巴', 'allow');
INSERT INTO `campany` VALUES ('天堂伞', '9594B94A209BD8918E18F9EFA8AB9432', '天堂伞', '');
INSERT INTO `campany` VALUES ('深夜食堂', '9594B94A209BD8918E18F9EFA8AB9432', '深夜食堂', 'allow');
INSERT INTO `campany` VALUES ('北京同仁堂', '9594B94A209BD8918E18F9EFA8AB9432', '北京同仁堂', 'allow');
INSERT INTO `campany` VALUES ('456', '96EAED1499BFA27EBFC9A268C049A16E', '456', 'allow');

-- ----------------------------
-- Table structure for campany_info
-- ----------------------------
DROP TABLE IF EXISTS `campany_info`;
CREATE TABLE `campany_info`  (
  `name` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `position` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `num` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `description` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL
) ENGINE = MyISAM AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_unicode_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of campany_info
-- ----------------------------
INSERT INTO `campany_info` VALUES ('京东', '北京', '101', '无');
INSERT INTO `campany_info` VALUES ('阿里巴巴', '杭州', '90', '无');
INSERT INTO `campany_info` VALUES ('华为', '广州、深圳、北京', '200', '只收硕士学历以上');

-- ----------------------------
-- Table structure for chat
-- ----------------------------
DROP TABLE IF EXISTS `chat`;
CREATE TABLE `chat`  (
  `studentName` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `campanyName` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `say` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of chat
-- ----------------------------
INSERT INTO `chat` VALUES ('123', '天堂伞', '你好！');
INSERT INTO `chat` VALUES ('123', '天堂伞', '123');
INSERT INTO `chat` VALUES ('123', '天堂伞', '你也好！！');
INSERT INTO `chat` VALUES ('123', '天堂伞', '我太好了！！');
INSERT INTO `chat` VALUES ('123', '123', '你不好！');
INSERT INTO `chat` VALUES ('123', '123', '不！我很好！');
INSERT INTO `chat` VALUES ('刘静远', '阿狸巴巴', '你被录用了！');
INSERT INTO `chat` VALUES ('刘静远', '阿狸巴巴', 'OK!');

-- ----------------------------
-- Table structure for chose_list
-- ----------------------------
DROP TABLE IF EXISTS `chose_list`;
CREATE TABLE `chose_list`  (
  `student_name` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `work_name` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `work_campany` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `student_phone` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `student_email` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `work_position` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `status` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT ''
) ENGINE = MyISAM AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_unicode_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of chose_list
-- ----------------------------
INSERT INTO `chose_list` VALUES ('222', '嵌入式开发工程师', '华为', '222', '222', '深圳', '');
INSERT INTO `chose_list` VALUES ('刘静远', '前端开发工程师', '阿狸巴巴', '123456789', '123456789@qq.com', '北京', 'allow');
INSERT INTO `chose_list` VALUES ('123', '123', '123', '123', '123', '123', '');

-- ----------------------------
-- Table structure for student
-- ----------------------------
DROP TABLE IF EXISTS `student`;
CREATE TABLE `student`  (
  `username` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `email` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `phone` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `status` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT ''
) ENGINE = MyISAM AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_unicode_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of student
-- ----------------------------
INSERT INTO `student` VALUES ('123', '9594B94A209BD8918E18F9EFA8AB9432', '123', '123', 'allow');
INSERT INTO `student` VALUES ('222', '847EEA811755E8EF3E47C260795AB4CC', '222', '222', 'allow');
INSERT INTO `student` VALUES ('刘远近', '9594B94A209BD8918E18F9EFA8AB9432', '123@qq.com', '123', 'allow');
INSERT INTO `student` VALUES ('147', '59455D97807C9D0A319E8369301F3701', '147', '147', '');
INSERT INTO `student` VALUES ('1234', '089BFE028819B9951FE9F2CA1552664E', '1234', '1234', 'allow');
INSERT INTO `student` VALUES ('789', 'CBA4709D45572320D4876576EFEB8566', '789', '789', 'allow');
INSERT INTO `student` VALUES ('刘静远', '3FEC82F91D74FFC86D60F88D1223330F', '123456789@qq.com', '123456789', 'allow');

-- ----------------------------
-- Table structure for studentlist
-- ----------------------------
DROP TABLE IF EXISTS `studentlist`;
CREATE TABLE `studentlist`  (
  `name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `age` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `school` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `tech` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `awa` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`name`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of studentlist
-- ----------------------------
INSERT INTO `studentlist` VALUES ('', '', '', '', '');
INSERT INTO `studentlist` VALUES ('123', '123', '123', '1234', '123');
INSERT INTO `studentlist` VALUES ('789', '789', '789', '789', '789');
INSERT INTO `studentlist` VALUES ('刘静远', '21', '哈尔滨理工大学', '前端开发专业技能', '一个大奖');

-- ----------------------------
-- Table structure for works
-- ----------------------------
DROP TABLE IF EXISTS `works`;
CREATE TABLE `works`  (
  `name` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `campany` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `position` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `num` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `re` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `phone` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `el` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  PRIMARY KEY (`name`) USING BTREE
) ENGINE = MyISAM AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_unicode_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of works
-- ----------------------------
INSERT INTO `works` VALUES ('前端开发工程师', '阿狸巴巴', '北京', '20', '本科及以上', '123', '无');
INSERT INTO `works` VALUES ('食堂试吃员', '深夜食堂', '食堂', '20', '胃口大', '456', '能吃');
INSERT INTO `works` VALUES ('吉祥物', '故宫', '北京', '1', '身高1米8', '1011', '会唱跳优先');
INSERT INTO `works` VALUES ('炼丹实习生', '天一门', '太行山', '20', '筑基', '1213', '水灵根和火灵根优先');
INSERT INTO `works` VALUES ('123', '123', '123', '123', '123', '123', '123');
INSERT INTO `works` VALUES ('456', '456', '456', '456', '456', '456', '56');
INSERT INTO `works` VALUES ('后端开发', '阿狸巴巴', '北京', '20', '会写字', '123456', '无');

SET FOREIGN_KEY_CHECKS = 1;
